using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Interfaces;

namespace Odey.Framework.Keeley.Entities
{
    partial class RawFXRate : IRawMarketDatum
    {
        int IRawMarketDatum.RawMarketDatumId
        {
            get
            {
                return RawFXRateId;
            }
        }

        #region IRawMarketDatum Members


        List<IMarketDatum> IRawMarketDatum.MarketData
        {
            get { 
                return FromFXRates.ToList<IMarketDatum>()
                        .Concat(ToFXRates.ToList<IMarketDatum>())
                        .Concat(FromSecondFXRates.ToList<IMarketDatum>())
                        .Concat(ToSecondFXRates.ToList<IMarketDatum>()).ToList(); }
        }

        #endregion
    }
}
