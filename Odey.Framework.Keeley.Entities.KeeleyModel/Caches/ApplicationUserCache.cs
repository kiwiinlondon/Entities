using System.Collections.Generic;
using Odey.Framework.Keeley.Entities;
using Odey.Framework.Infrastructure.Caches;
using System.Linq;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public class ApplicationUserByLoginCache : OdeyCache<string, ApplicationUser>
    {
        public override Dictionary<string, ApplicationUser> GetAll()
        {
            using (KeeleyModel context = new KeeleyModel())
            {
                return context.ApplicationUsers.Where(a=> a.WindowsLogin != null).ToDictionary(a => a.WindowsLogin.ToUpper(), a => a);
            }
        }

        protected override KeyNotFoundBehaviourIds KeyNotFoundBehaviour
        {
            get { return KeyNotFoundBehaviourIds.All; }
        }
    }
}
