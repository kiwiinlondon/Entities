using System;
using System.Collections.Generic;
using System.Linq;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public class InstrumentClassCache : KeeleyCache<int, InstrumentClass>
    {
        protected override Dictionary<int, InstrumentClass> CreateCache(KeeleyModel context)
        {
            return context.InstrumentClasses.ToDictionary(a => a.InstrumentClassID, a => a);
        }

        protected override KeyNotFoundBehaviourIds KeyNotFoundBehaviour
        {
            get { return KeyNotFoundBehaviourIds.All; }
        }
    }
}
