using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Interfaces;

namespace Odey.Framework.Keeley.Entities
{
    partial class RawAnalytic : IRawMarketDatum
    {
        int IRawMarketDatum.RawMarketDatumId
        {
            get
            {
                return RawAnalyticId;
            }
        }




        List<IMarketDatum> IRawMarketDatum.MarketData
        {
            get { return Analytics.ToList<IMarketDatum>(); }
        }
    }
}
