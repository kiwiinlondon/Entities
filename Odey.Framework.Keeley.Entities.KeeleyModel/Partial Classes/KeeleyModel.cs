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

namespace Odey.Framework.Keeley.Entities
{
    partial class KeeleyModel
    {
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
                    ApplicationUser user = null;
                    PropertyInfo updateUserNamePropInfo = entry.Entity.GetType().GetProperty("UserThatCausedChange");
                    string updateUserName = null;
                    if (updateUserNamePropInfo != null)
                    {
                        updateUserName = (string)updateUserNamePropInfo.GetValue(entry.Entity, null);
                        if (updateUserName != null)
                        {                           
                            user = ApplicationUserCache.Get(updateUserName);
                        }
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
