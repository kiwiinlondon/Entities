using System.Collections.Generic;
using Odey.Framework.Keeley.Entities;
using Odey.Framework.Infrastructure.Caches;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public abstract class KeeleyCache<K, T> : OdeyCache<K, T>
    {        
        protected abstract Dictionary<K, T> CreateCache(KeeleyModel context);

        public override Dictionary<K, T> GetAll()
        {
            using (KeeleyModel context = new KeeleyModel())
            {
                return CreateCache(context);
            }
        }
    }
}