﻿using System;
using System.Collections.Generic;
using System.Linq;
using Odey.Framework.Keeley.Entities;
using System.Threading;

namespace Odey.Framework.Keeley.Entities.Caches
{
    internal static class ApplicationUserCache
    {
        private static ReaderWriterLock rwl = new ReaderWriterLock();

        private static Dictionary<string, ApplicationUser> _map = null;
        
        private static void Refresh()
        {
            using (KeeleyModel context = new KeeleyModel())
            {
                LockCookie cookie = rwl.UpgradeToWriterLock(3000);
                _map = context.ApplicationUsers.ToDictionary(a => a.WindowsLogin, a => a);
                rwl.DowngradeFromWriterLock(ref cookie);
            }
        }
        public static ApplicationUser Get(string key)
        {
            try
            {
                rwl.AcquireReaderLock(3000);

                if (_map == null)
                {
                    Refresh();
                }
                ApplicationUser value = null;
                if (!_map.TryGetValue(key, out value))
                {
                    Refresh();//just in case this key has been setup in the meantime
                    _map.TryGetValue(key, out value);
                }
                return value;
            }
            finally
            {
                rwl.ReleaseLock();
            }
        }
    }
}
