using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Caches
{

    public class EntityTypeCache : KeeleyCache<string, EntityType>
    {
        protected override Dictionary<string, EntityType> CreateCache(KeeleyModel context)
        {
            return context.EntityTypes.Include(a=>a.EntityProperties).ToDictionary(a => a.FullyQualifiedName, a => a);
        }


        protected override KeyNotFoundBehaviourIds KeyNotFoundBehaviour
        {
            get { return KeyNotFoundBehaviourIds.All; }
        }
    }
}
