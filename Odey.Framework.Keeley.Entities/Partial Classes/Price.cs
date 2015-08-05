using System;
using Odey.Framework.Keeley.Entities.Interfaces;
using System.Collections.Generic;

namespace Odey.Framework.Keeley.Entities
{
    partial class Price : IMarketDatum
    {

        #region IMarketDatum Members


        public List<IRawMarketDatum> RawMarketData
        {
            get 
            {
                if (RawPrice == null)
                {
                    return new List<IRawMarketDatum>();
                }
                return new List<IRawMarketDatum> { RawPrice }; 
            }
        }

        public override string ToString()
        {
            return String.Format("PriceId: {0} - InstrumentMarketId: {1} ReferenceDate: {2} - RawPriceId: {3} Value: {4} EntityRankingSchemeId: {5}", this.PriceId, this.InstrumentMarketId, this.ReferenceDate, this.RawPriceId, this.Value, this.EntityRankingSchemeId);
        }

        #endregion
    }
}
