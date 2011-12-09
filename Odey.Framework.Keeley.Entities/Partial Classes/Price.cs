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

        #endregion
    }
}
