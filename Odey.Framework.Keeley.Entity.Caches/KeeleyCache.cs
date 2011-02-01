using System;
using System.Collections.Generic;
using System.Linq;
using Odey.Framework.Keeley.Entities.Enums;
using Odey.Framework.Keeley.Entities;
using System.Threading;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public abstract class KeeleyCache<K,T> where T : IObjectWithChangeTracker
    {
        private static ReaderWriterLock rwl = new ReaderWriterLock();

        private static Dictionary<K, T> _map = null;
        protected abstract Dictionary<K, T> CreateCache(KeeleyModel context);

        private void Refresh()
        {
            LockCookie cookie = rwl.UpgradeToWriterLock(3000);
            using (KeeleyModel context = new KeeleyModel())
            {                
                _map = CreateCache(context);                
            }
            rwl.DowngradeFromWriterLock(ref cookie);
        }
        public T Get(K key)
        {
            try
            {
                rwl.AcquireReaderLock(3000);

                if (_map == null)
                {                    
                    Refresh();
                }
                T value = default(T);
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