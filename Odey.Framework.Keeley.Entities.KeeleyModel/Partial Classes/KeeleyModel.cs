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
                PropertyInfo propInfo = entry.Entity.GetType().GetProperty("UpdateUserID");
                if (propInfo != null)
                {
                    ApplicationUser user = ApplicationUserCache.GetApplicationUserForWindowsLogin(WindowsIdentity.GetCurrent().Name); 
                    propInfo.SetValue(entry.Entity,user.UserID,null);
                }
            }
            return base.SaveChanges(options);
        }


    }
}
