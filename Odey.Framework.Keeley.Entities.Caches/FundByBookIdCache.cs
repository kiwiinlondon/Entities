using System;
using System.Collections.Generic;
using System.Linq;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities.Caches
{
    public class FundByBookIdCache : KeeleyCache<int, Fund>
    {
        protected override Dictionary<int, Fund> CreateCache(KeeleyModel context)
        {
            return context.Books.Include("Fund").ToDictionary(a => a.BookID, a => a.Fund);
        }

        protected override KeyNotFoundBehaviourIds KeyNotFoundBehaviour
        {
            get { return KeyNotFoundBehaviourIds.All; }
        }
    }
}