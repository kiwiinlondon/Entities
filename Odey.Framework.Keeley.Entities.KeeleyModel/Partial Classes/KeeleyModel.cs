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
using Odey.Framework.Keeley.Entities.Enums.Extensions;
using ServiceModelEx;
using Odey.Framework.Keeley.Entities.Enums;
using Odey.Framework.Infrastructure.Contracts;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Transactions;
//using System.Data.Entity.Infrastructure;

namespace Odey.Framework.Keeley.Entities
{
    partial class KeeleyModel
    {

        private SecurityCallStack _securityCallStack = null;


        #region Application User Id
        


        private int ApplicationUserId
        {
            get
            {
                if (!_applicationUserIdOverride.HasValue)
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
                    string updateUserName = callFrame.IdentityName.ToUpper();

                    if (string.IsNullOrWhiteSpace(updateUserName))
                    {
                        throw new ApplicationException("Unable to establish update user name");
                    }
                    ApplicationUserByLoginCache cache = new ApplicationUserByLoginCache();
                    var user = cache.Get(updateUserName);
                    if (user == null)
                    {
                        throw new ApplicationException($"User {updateUserName} is not authorised to make changes");
                    }
                    return user.UpdateUserID;

                }
                else
                {
                    return _applicationUserIdOverride.Value;
                }
            }
        }
        #endregion


        #region Constructor

        public KeeleyModel(SecurityCallStack securityCallStack)
            : this(securityCallStack,null)
        {

        }

        public string _applicationName;
        public int? _applicationUserIdOverride;

        public KeeleyModel(SecurityCallStack securityCallStack, string applicationName)
            : this()
        {
            _changedEntityManager = new ChangedEntityManager();
            if (applicationName == null)
            {
                applicationName = ConfigurationManager.AppSettings["ApplicationName"];
            }
            if (applicationName != null)
            {
                _applicationName = applicationName;
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(this.Database.Connection.ConnectionString);
                builder.ApplicationName = applicationName;
                this.Database.Connection.ConnectionString = builder.ConnectionString;
            }
            else
            {
                _applicationName = "Not Supplied";
            }
            _securityCallStack = securityCallStack;

            ((IObjectContextAdapter)this).ObjectContext.ObjectMaterialized += (sender, args) =>
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


        //private void AddToChangedEntities(DbEntityEntry entry, Dictionary<DbEntityEntry, ChangedEntity> changedEntitiesByEntry)
        //{

        //    ChangedEntity changedEntity = new ChangedEntity(entry.Entity.GetType(), entry.State);
        //    changedEntitiesByEntry.Add(entry, changedEntity);
        //    if (entry.State == EntityState.Deleted)
        //    {
        //        changedEntity.Key = GetPrimaryKeyValue(entry);
        //    }
        //    AddUsefulFields(entry, changedEntity);
        //}

        private EntityKeyMember[] GetPrimaryKeyValue(DbEntityEntry entry)
        {
            var objectStateEntry = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
            return objectStateEntry.EntityKey.EntityKeyValues;
        }

        //private void EnhanceChangedEntities(Dictionary<DbEntityEntry, ChangedEntity> addedEntities)
        //{
        //    foreach (KeyValuePair<DbEntityEntry, ChangedEntity> change in addedEntities)
        //    {
        //        if (change.Value.EntityState != EntityState.Deleted)
        //        {
        //            change.Value.Key = GetPrimaryKeyValue(change.Key);
        //        }
        //    }

        //}

        //private void AddUsefulFields(DbEntityEntry entry, ChangedEntity changedEntity)
        //{
        //    Type entityType = entry.Entity.GetType();

        //    DbPropertyValues values;
        //    if (entry.State == EntityState.Deleted)
        //    {
        //        values = entry.OriginalValues;
        //    }
        //    else
        //    {
        //        values = entry.CurrentValues;
        //    }

        //    if (entityType == typeof(Portfolio))
        //    {
        //        AddValueToUsefulProperties(changedEntity, values, "PositionId");
        //        AddValueToUsefulProperties(changedEntity, values, "ReferenceDate");
        //    }
        //    else if (entityType == typeof(PortfolioEvent))
        //    {
        //        AddValueToUsefulProperties(changedEntity, values, "PositionId");
        //        AddValueToUsefulProperties(changedEntity, values, "ReferenceDate");
        //    }
        //    else if (entityType == typeof(Instrument))
        //    {
        //        AddValueToUsefulProperties(changedEntity, values, "InstrumentClassID");
        //    }
        //    else if (entityType == typeof(InstrumentMarket))
        //    {
        //        AddValueToUsefulPropertiesUsingReflection(entry, "InstrumentClassID", changedEntity);
        //    }
        //    else if (entityType == typeof(FundPerformance))
        //    {
        //        AddValueToUsefulPropertiesUsingReflection(entry, "FundId", changedEntity);
        //    }
        //    else if (entityType == typeof(Analytic))
        //    {
        //        AddValueToUsefulPropertiesUsingReflection(entry, "AnalyticTypeID", changedEntity);
        //    }
        //}

        //private void AddValueToUsefulProperties(ChangedEntity changedEntity, DbPropertyValues currentValues, string key)
        //{
        //    changedEntity.UsefulProperties.Add(key, currentValues[key]);
        //}

        //private void AddValueToUsefulPropertiesUsingReflection(DbEntityEntry entry, string key, ChangedEntity changedEntity)
        //{
        //    PropertyInfo propInfo = entry.Entity.GetType().GetProperty(key);
        //    object value = propInfo.GetValue(entry.Entity, null);
        //    changedEntity.UsefulProperties.Add(key, value);
        //}

        #endregion

        #region Save Changes
        public Dictionary<object,DbPropertyValues> GetModifiedEntities()
        {
            Dictionary<object, DbPropertyValues> originalValues = new Dictionary<object, DbPropertyValues>();
            foreach (DbEntityEntry entry in this.ChangeTracker.Entries().Where(p => p.State == System.Data.EntityState.Modified))
            {
                originalValues.Add(entry.Entity, entry.OriginalValues);                
            }
            return originalValues;
        }

        //private Dictionary<DbEntityEntry, ChangedEntity> GetChangedEntites()
        //{
        //    Dictionary<DbEntityEntry, ChangedEntity>  changedEntitiesByEntry = new Dictionary<DbEntityEntry, ChangedEntity>();

        //    foreach (DbEntityEntry entry in this.ChangeTracker.Entries().Where(p => p.State == System.Data.EntityState.Added || p.State == System.Data.EntityState.Deleted || p.State == System.Data.EntityState.Modified))
        //    {
        //        if (PopulateChangedEntities)
        //        {
        //            AddToChangedEntities(entry, changedEntitiesByEntry);
        //        }
        //        SetUpdateUserId(entry);
        //    }
        //    return changedEntitiesByEntry;
        //}

        private void SetUpdateUserId(DbEntityEntry entry, int updateUserId)
        {
            if (entry.State != EntityState.Deleted)
            {
                PropertyInfo updateUserIdPropInfo = entry.Entity.GetType().GetProperty("UpdateUserID");

                if (updateUserIdPropInfo != null)
                {
                    updateUserIdPropInfo.SetValue(entry.Entity, updateUserId, null);
                }
            }
        }

        private ChangedEntityManager _changedEntityManager;
        private void ProcessChangedEntities()
        {
            int userId = ApplicationUserId;
            foreach (DbEntityEntry entry in this.ChangeTracker.Entries().Where(p => p.State == System.Data.EntityState.Added || p.State == System.Data.EntityState.Deleted || p.State == System.Data.EntityState.Modified))
            {
                _changedEntityManager.AddChangedEntity(this,entry);
                SetUpdateUserId(entry, userId);
            }
        }

        public List<ChangedEntity> ChangedEntities { get; private set; } 




        public override int SaveChanges()
        {
            ProcessChangedEntities();
            int toReturn = 0;
            var transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
            transactionOptions.Timeout = TransactionManager.MaximumTimeout;

            using (var scope = new TransactionScope(TransactionScopeOption.Required,transactionOptions))
            {
                toReturn = base.SaveChanges();
                _changedEntityManager.EnhanceChangedEntities(this);
                _changedEntityManager.SendMessages(this,_applicationName);                                
                scope.Complete();                
            }
            ChangedEntities = _changedEntityManager.ChangedEntities;
            _changedEntityManager = new ChangedEntityManager();
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
