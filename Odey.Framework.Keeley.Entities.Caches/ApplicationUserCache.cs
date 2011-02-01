using System;
using System.Collections.Generic;
using System.Linq;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public class ApplicationUserCache : KeeleyCache<int, ApplicationUser>
    {
        protected override Dictionary<int, ApplicationUser> CreateCache(KeeleyModel context)
        {
            return context.ApplicationUsers.ToDictionary(a => a.UserID, a => a);
        }
    }
}
