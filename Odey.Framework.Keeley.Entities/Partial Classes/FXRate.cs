using System;
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

        public decimal GetOrientatedValue(int fromCurrencyId)
        {
            if (FromCurrencyId == fromCurrencyId)
            {
                return Value;
            }
            return 1 / Value;
        }

        public override string ToString()
        {
            return String.Format("FXRateId: {0} - FromCurrencyId: {1} - ToCurrencyId: {2} - ReferenceDate: {3} - EntityRankingSchemeId: {4} - ForwardDate: {5}" +
                                 " - Value: {6} - FromRawFXRateId: {7} - ToRawFXRateId: {8} - FromSecondRawFXRateId: {9} - ToSecondRawFXRateId: {10}", this.FXRateId, this.FromCurrencyId, 
                                 this.ToCurrencyId, this.ReferenceDate, this.EntityRankingSchemeId, this.ForwardDate, this.Value,
                                 this.FromRawFXRateId, this.ToRawFXRateId, this.FromSecondRawFXRateId, this.ToSecondRawFXRateId);
        }

        public int Id => FXRateId;
    }
}