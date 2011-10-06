using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Interfaces;

namespace Odey.Framework.Keeley.Entities
{
    partial class RawPrice : IRawMarketDatum
    {
        int IRawMarketDatum.RawMarketDatumId
        {
            get
            {
                return RawPriceId;
            }
        }

     


        List<IMarketDatum> IRawMarketDatum.MarketData
        {
            get { return Prices.ToList<IMarketDatum>(); }
        }



        
    }
}
