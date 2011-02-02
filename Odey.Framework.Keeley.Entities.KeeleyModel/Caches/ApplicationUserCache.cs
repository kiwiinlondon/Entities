using System.Collections.Generic;
using Odey.Framework.Keeley.Entities;
using Odey.Framework.Infrastructure.Caches;
using System.Linq;

namespace Odey.Framework.Keeley.Entities.Caches
{
    internal class ApplicationUserCache : OdeyCache<string, ApplicationUser>
    {
        protected override Dictionary<string, ApplicationUser> GetAll()
        {
            using (KeeleyModel context = new KeeleyModel())
            {
                return context.ApplicationUsers.ToDictionary(a => a.WindowsLogin, a => a);
            }
        }
    }
}
