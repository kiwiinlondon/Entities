using System;
using System.Collections.Generic;
using System.Linq;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public static class ApplicationUserCache
    {

        private static object syncRoot = new Object();
        private static Dictionary<string, ApplicationUser> _map = null;

        private static void Refresh()
        {
            using (var context = new KeeleyModel())
            {
                _map = context.ApplicationUsers.ToDictionary(a => a.WindowsLogin, a => a);
            }
        }
        
        public static ApplicationUser GetApplicationUserForWindowsLogin(string windowsLogin)
        {
            //reading lock
            lock (syncRoot)
            {
                if (_map == null)
                {
                    Refresh();
                }
                ApplicationUser user = null;
                if (!_map.TryGetValue(windowsLogin, out user))
                {
                    throw new ApplicationException("User is not setup");
                }
                return user;
            }
        }

        
    }
}

