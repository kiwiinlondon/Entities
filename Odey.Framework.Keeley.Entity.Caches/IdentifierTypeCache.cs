using System;
using System.Collections.Generic;
using System.Linq;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public class IdentifierTypeCache : KeeleyCache<IdentifierTypeIds, IdentifierType>
    {
        protected override Dictionary<IdentifierTypeIds, IdentifierType> CreateCache(KeeleyModel context)
        {
            return context.IdentifierTypes.ToDictionary(a => a.IdentifierTypeIDAsEnum, a => a);
        }
    }
}
