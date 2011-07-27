using Odey.Framework.Keeley.Entities.Interfaces;
using System.Collections.Generic;

namespace Odey.Framework.Keeley.Entities
{
    partial class FXRate : IMarketDatum
    {

        #region IMarketDatum Members


        public List<IRawMarketDatum> RawMarketData
        {
            get 
            { 
                List<IRawMarketDatum> rawMarketData = new List<IRawMarketDatum>();
                
                AddIfNotNull(FromRawFXRate,rawMarketData);
                AddIfNotNull(ToRawFXRate,rawMarketData);
                AddIfNotNull(FromSecondRawFXRate,rawMarketData);
                AddIfNotNull(ToSecondRawFXRate,rawMarketData);
                return rawMarketData;
            }
        }

        private void AddIfNotNull(RawFXRate rawMarketDatum, List<IRawMarketDatum> rawMarketData)
        {
            if (rawMarketDatum != null)
            {
                rawMarketData.Add(rawMarketDatum);
            }
        }

        #endregion
    }
}