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

namespace Odey.Framework.Keeley.Entities
{
    partial class KeeleyModel
    {

        private SecurityCallStack _securityCallStack = null;

        public KeeleyModel(SecurityCallStack securityCallStack) : this()
        {
            _securityCallStack = securityCallStack;
        }

        public override int SaveChanges(SaveOptions options)
        {
            //needed to bring context back in line with entity
            DetectChanges();
            foreach (ObjectStateEntry entry in
                ObjectStateManager.GetObjectStateEntries(
                EntityState.Added | EntityState.Modified))
            {
                PropertyInfo updateUserIdPropInfo = entry.Entity.GetType().GetProperty("UpdateUserID");

                if (updateUserIdPropInfo != null)
                {
                    if (_securityCallStack == null)
                    {
                        throw new ApplicationException("No Security call stack was provided in constructor so user cannot be authenticated");
                    }
                    ApplicationUser user = null;
                    SecurityCallFrame callFrame = _securityCallStack.OriginalCall;
                    if (callFrame == null)
                    {
                        throw new ApplicationException("Original Call frame was not supplied so user cannot be authenticated");
                    }
                    string updateUserName = callFrame.IdentityName;

                    if (updateUserName != null)
                    {
                        ApplicationUserByLoginCache cache = new ApplicationUserByLoginCache();
                        user = cache.Get(updateUserName);
                    }
                    if (user == null)
                    {
                        throw new ApplicationException(String.Format("User {0} is not authorised to make changes to entity type {1}", updateUserName, entry.Entity.GetType().ToString()));
                    }
                    else
                    {
                        updateUserIdPropInfo.SetValue(entry.Entity, user.UserID, null);
                    }
                }
            }
            return base.SaveChanges(options);
        }
    }
}
