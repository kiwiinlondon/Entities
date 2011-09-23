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

namespace Odey.Framework.Keeley.Entities
{
    partial class KeeleyModel
    {

        private SecurityCallStack _securityCallStack = null;

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

        public KeeleyModel(SecurityCallStack securityCallStack) : this()
        {
            _securityCallStack = securityCallStack;
        }

        public List<ChangedEntity> ChangedEntities { get; set; }

        private void AddToChangedEntities(ObjectStateEntry entry, Dictionary<ObjectStateEntry, ChangedEntity> addedEntities)
        {
            ChangedEntity changedEntity = new ChangedEntity(entry.Entity.GetType(), entry.EntityKey.EntityKeyValues, entry.State);
            if (entry.State == EntityState.Modified)
            {
                foreach (string modifiedPropertyName in entry.GetModifiedProperties())
                {
                    object originalValue = entry.OriginalValues[modifiedPropertyName];
                    object currentValue = entry.CurrentValues[modifiedPropertyName];

                    if (originalValue == null && currentValue != null || originalValue != null && currentValue == null || !originalValue.Equals(currentValue))
                    {                        
                        changedEntity.ChangedProperties.Add(modifiedPropertyName, new ChangedProperty(entry.OriginalValues.GetFieldType(entry.OriginalValues.GetOrdinal(modifiedPropertyName)), originalValue, currentValue));
                    }
                }
            }
            ChangedEntities.Add(changedEntity);
            if (entry.State == EntityState.Added)
            {
                addedEntities.Add(entry, changedEntity);
            }
        }

        public override int SaveChanges(SaveOptions options)
        {
            //needed to bring context back in line with entity
            ChangedEntities = new List<ChangedEntity>();
            Dictionary<ObjectStateEntry, ChangedEntity> addedEntities = new Dictionary<ObjectStateEntry, ChangedEntity>();
            DetectChanges();
            foreach (ObjectStateEntry entry in
                ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            {
                AddToChangedEntities(entry, addedEntities);
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
            int toReturn = base.SaveChanges(options);
            EnhanceKeysForAdds(addedEntities);
            return toReturn;
        }

        private void EnhanceKeysForAdds (Dictionary<ObjectStateEntry, ChangedEntity> addedEntities)
        {
            foreach (KeyValuePair<ObjectStateEntry, ChangedEntity> change in addedEntities)
            {
                change.Value.Key = change.Key.EntityKey.EntityKeyValues;
            }
        }
    }
}
