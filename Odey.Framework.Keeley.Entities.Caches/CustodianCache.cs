using System;
using System.Collections.Generic;
using System.Linq;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public class CustodianCache : KeeleyCache<int, Custodian>
    {
        protected override Dictionary<int, Custodian> CreateCache(KeeleyModel context)
        {
            return context.Custodians.Include("LegalEntity").ToDictionary(a => a.LegalEntityID, a => a);
        }

        protected override KeyNotFoundBehaviourIds KeyNotFoundBehaviour
        {
            get { return KeyNotFoundBehaviourIds.All; }
        }
    }
}
