using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Interfaces
{
    public interface IRawMarketDatum
    {
        int RawMarketDatumId { get; }
        int EntityRankingSchemeItemId { get; }
        DateTime ReferenceDate { get; }
        List<IMarketDatum> MarketData { get; }
        decimal BidValue { get; set; }
        decimal AskValue { get; set; }
        DateTime BidUpdateDate { get; set; }
        DateTime AskUpdateDate { get; set; } 
    }
}
