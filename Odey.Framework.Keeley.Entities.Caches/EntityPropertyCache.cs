using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public class EntityPropertyCache : KeeleyCache<int, EntityProperty>
    {
        protected override Dictionary<int, EntityProperty> CreateCache(KeeleyModel context)
        {
            return context.EntityProperties.ToDictionary(a => a.EntityPropertyID, a => a);
        }

        public EntityProperty GetPrimaryKeyForEntityId(int entityId)
        {
            return null;
            //GetAll().FirstOrDefault(a=>a.Value.EntityTypeId == entityId && a.Value.i)
        }

        protected override KeyNotFoundBehaviourIds KeyNotFoundBehaviour
        {
            get { return KeyNotFoundBehaviourIds.All; }
        }
    }
}
