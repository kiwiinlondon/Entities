using System.Collections.Generic;
using Odey.Framework.Keeley.Entities;
using Odey.Framework.Infrastructure.Caches;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public abstract class KeeleyCache<K, T> : OdeyCache<K, T> where T : IObjectWithChangeTracker
    {        
        protected abstract Dictionary<K, T> CreateCache(KeeleyModel context);

        protected override Dictionary<K, T> GetAll()
        {
            using (KeeleyModel context = new KeeleyModel())
            {
                return CreateCache(context);
            }
        }
    }
}