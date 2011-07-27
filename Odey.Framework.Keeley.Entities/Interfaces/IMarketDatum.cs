using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Interfaces
{
    public interface IMarketDatum
    {
        int EntityRankingSchemeId { get; }
        DateTime ReferenceDate { get; }
        decimal Value { get; }
        List<IRawMarketDatum> RawMarketData { get; }
    }
}
