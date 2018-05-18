using Odey.Framework.Keeley.Entities.Enums;
using Odey.Framework.Keeley.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class Beta : IMarketDatum
    {
        public int EntityRankingSchemeId => (int)EntityRankingSchemeIds.Default;        

        public List<IRawMarketDatum> RawMarketData => throw new NotImplementedException();
    }
}
