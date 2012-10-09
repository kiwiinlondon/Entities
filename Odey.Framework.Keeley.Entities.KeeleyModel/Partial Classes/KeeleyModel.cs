using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data;
using System.Reflection;
using Odey.Framework.Keeley.Entities.Caches;
using Odey.Framework.Keeley.Entities;
using System.Security.Principal;
using ServiceModelEx;
using Odey.Framework.Keeley.Entities.Enums;
using Odey.Framework.Infrastructure.Contracts;
using System.Data.Entity.Infrastructure;
//using System.Data.Entity.Infrastructure;

namespace Odey.Framework.Keeley.Entities
{
    partial class KeeleyModel
    {

        private SecurityCallStack _securityCallStack = null;

        #region Application User Id
        public int? ApplicationUserId
        {
            get
            {
                string updateUserName;
                return GetApplicationUserId(out updateUserName);
            }
        }


        private int? GetApplicationUserId(out string updateUserName)
        {
            if (_securityCallStack == null)
            {
                throw new ApplicationException("No Security call stack was provided in constructor so user cannot be authenticated");
            }
            SecurityCallFrame callFrame = _securityCallStack.OriginalCall;
            if (callFrame == null)
            {
                throw new ApplicationException("Original Call frame was not supplied so user cannot be authenticated");
            }
            updateUserName = callFrame.IdentityName;
            ApplicationUser user = null;
            if (updateUserName != null)
            {
                ApplicationUserByLoginCache cache = new ApplicationUserByLoginCache();
                user = cache.Get(updateUserName);
            }
            if (user == null)
            {
                return null;
            }
            else
            {
                return user.UserID;
            }
        }
        #endregion

        #region Constructor
        public KeeleyModel(SecurityCallStack securityCallStack)
            : this()
        {
            _securityCallStack = securityCallStack;
            
            ((IObjectContextAdapter)this).ObjectContext
                .ObjectMaterialized += (sender, args) =>
                {
                    var entity = args.Entity as IObjectWithState;
                    if (entity != null)
                    {
                        entity.State = State.Unchanged;
                        entity.OriginalValues = BuildOriginalValues(this.Entry(entity).OriginalValues);
                    }
                };
        }



        private static Dictionary<string, object> BuildOriginalValues(DbPropertyValues originalValues)
        {
            var result = new Dictionary<string, object>();

            foreach (var propertyName in originalValues.PropertyNames)
            {
                var value = originalValues[propertyName];
                if (value is DbPropertyValues)
                {
                    result[propertyName] = BuildOriginalValues((DbPropertyValues)value);
                }
                else
                {
                    result[propertyName] = value;
                }
            }
            return result;
        }
        #endregion

        #region Changed Entities
        public List<ChangedEntity> ChangedEntities { get; set; }

        private static object ConvertDBNUll(object objectToTest)
        {
            if (objectToTest.GetType() == typeof(System.DBNull))
            {
                return null;
            }
            return objectToTest;
        }

        private void AddToChangedEntities(DbEntityEntry entry, Dictionary<DbEntityEntry, ChangedEntity> changedEntitiesByEntry)
        {

            ChangedEntity changedEntity = new ChangedEntity(entry.Entity.GetType(), entry.State);

            if (entry.State == EntityState.Modified)
            {
                foreach (var modifiedPropertyName in entry.CurrentValues.PropertyNames)
                {
                    object originalValue = entry.OriginalValues.GetValue<object>(modifiedPropertyName);
                    object currentValue = entry.CurrentValues.GetValue<object>(modifiedPropertyName);

                    if (!(originalValue == null && currentValue == null))
                    {
                        Type type;
                        if (originalValue == null)
                        {
                            type = currentValue.GetType();
                        }
                        else
                        {
                            type = originalValue.GetType();
                        }

                        if ((originalValue == null && currentValue != null) || (originalValue != null && currentValue == null) || !originalValue.Equals(currentValue))
                        {
                            changedEntity.ChangedProperties.Add(modifiedPropertyName, new ChangedProperty(type, originalValue, currentValue));
                        }
                    }
                }
            }

            ChangedEntities.Add(changedEntity);
            changedEntitiesByEntry.Add(entry, changedEntity);
            if (entry.State == EntityState.Deleted)
            {
                changedEntity.Key = GetPrimaryKeyValue(entry);
            }
            AddUsefulFields(entry, changedEntity);
        }

        private EntityKeyMember[] GetPrimaryKeyValue(DbEntityEntry entry)
        {
            var objectStateEntry = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
            return objectStateEntry.EntityKey.EntityKeyValues;
        }

        private void EnhanceChangedEntities(Dictionary<DbEntityEntry, ChangedEntity> addedEntities)
        {
            foreach (KeyValuePair<DbEntityEntry, ChangedEntity> change in addedEntities)
            {
                if (change.Value.EntityState != EntityState.Deleted)
                {
                    change.Value.Key = GetPrimaryKeyValue(change.Key);
                    change.Value.DataVersion = (byte[])change.Key.CurrentValues["DataVersion"];
                }
            }

        }

        private void AddUsefulFields(DbEntityEntry entry, ChangedEntity changedEntity)
        {
            Type entityType = entry.Entity.GetType();

            DbPropertyValues values; 
            if (entry.State == EntityState.Deleted)
            {
                values = entry.OriginalValues;
            }
            else
            {
                values = entry.CurrentValues;
            } 

            if (entityType == typeof(Portfolio))
            {
                AddValueToUsefulProperties(changedEntity, values, "PositionId");
                AddValueToUsefulProperties(changedEntity, values, "ReferenceDate");
            }
            else if (entityType == typeof(PortfolioEvent))
            {
                AddValueToUsefulProperties(changedEntity, values, "PositionId");
                AddValueToUsefulProperties(changedEntity, values, "ReferenceDate");
            }
            else if (entityType == typeof(Instrument))
            {
                AddValueToUsefulProperties(changedEntity, values, "InstrumentClassID");
            }
            else if (entityType == typeof(InstrumentMarket))
            {
                AddValueToUsefulPropertiesUsingReflection(entry, "InstrumentClassID", changedEntity);
            }
            else if (entityType == typeof(FundPerformance))
            {
                AddValueToUsefulPropertiesUsingReflection(entry, "FundId", changedEntity);
            }
            else if (entityType == typeof(Analytic))
            {
                AddValueToUsefulPropertiesUsingReflection(entry, "AnalyticTypeID", changedEntity);
            }
        }

        private void AddValueToUsefulProperties(ChangedEntity changedEntity, DbPropertyValues currentValues, string key)
        {
            changedEntity.UsefulProperties.Add(key, currentValues[key]);
        }

        private void AddValueToUsefulPropertiesUsingReflection(DbEntityEntry entry, string key, ChangedEntity changedEntity)
        {
            PropertyInfo propInfo = entry.Entity.GetType().GetProperty(key);
            object value = propInfo.GetValue(entry.Entity, null);
            changedEntity.UsefulProperties.Add(key, value);
        }

        #endregion

        #region Save Changes
        public override int SaveChanges()
        {
            //needed to bring context back in line with entity
            ChangedEntities = new List<ChangedEntity>();
            Dictionary<DbEntityEntry, ChangedEntity> changedEntitiesByEntry = new Dictionary<DbEntityEntry, ChangedEntity>();

            foreach (DbEntityEntry entry in this.ChangeTracker.Entries().Where(p => p.State == System.Data.EntityState.Added || p.State == System.Data.EntityState.Deleted || p.State == System.Data.EntityState.Modified))
            {

                AddToChangedEntities(entry, changedEntitiesByEntry);
                if (entry.State != EntityState.Deleted)
                {
                    PropertyInfo updateUserIdPropInfo = entry.Entity.GetType().GetProperty("UpdateUserID");

                    if (updateUserIdPropInfo != null)
                    {
                        string updateUserName;
                        int? userId = GetApplicationUserId(out updateUserName);
                        if (userId == null)
                        {
                            throw new ApplicationException(String.Format("User {0} is not authorised to make changes to entity type {1}", updateUserName, entry.Entity.GetType().ToString()));
                        }
                        else
                        {
                            updateUserIdPropInfo.SetValue(entry.Entity, userId.Value, null);
                        }
                    }
                }
            }
            int toReturn = base.SaveChanges();
            EnhanceChangedEntities(changedEntitiesByEntry);
            return toReturn;
        }


        #endregion

        #region Apply Changes



        public void AddDetached<TEntity>(List<TEntity> roots) where TEntity : class, IObjectWithState
        {
            foreach (TEntity entity in roots)
            {
                AddDetached<TEntity>(entity);
            }
        }

        public void AddDetached<TEntity>(TEntity root) where TEntity : class, IObjectWithState
        {
            Set<TEntity>().Add(root);
        }

        public void ApplyDetached()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is IObjectWithState)
                {
                    IObjectWithState stateInfo = (IObjectWithState)entry.Entity;
                    entry.State = ConvertState(stateInfo.State);
                    if (stateInfo.State == State.Unchanged)
                    {
                        ApplyPropertyChanges(entry.OriginalValues, stateInfo.OriginalValues);
                    }
                }
                else
                {
                    entry.State = EntityState.Unchanged;
                }
            }
        }

        //private void CheckForEntitiesWithoutStateInterface() 
        //{ 
        //    var entitiesWithoutState = from e in ChangeTracker.Entries() 
        //                               where !(e.Entity is IObjectWithState) select e; 
        //    if (entitiesWithoutState.Any()) 
        //    { 
        //        throw new NotSupportedException("All entities must implement IObjectWithState"); 
        //    } 
        //}


        public static EntityState ConvertState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

        private static void ApplyPropertyChanges(DbPropertyValues values, Dictionary<string, object> originalValues)
        {
            foreach (var originalValue in originalValues)
            {
                if (originalValue.Value is Dictionary<string, object>)
                {
                    ApplyPropertyChanges((DbPropertyValues)values[originalValue.Key], (Dictionary<string, object>)originalValue.Value);
                }
                else
                {
                    values[originalValue.Key] = originalValue.Value;
                }
            }
        }

        #endregion
    }
}
