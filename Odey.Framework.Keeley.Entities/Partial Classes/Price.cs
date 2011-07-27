using Odey.Framework.Keeley.Entities.Interfaces;
using System.Collections.Generic;

namespace Odey.Framework.Keeley.Entities
{
    partial class Price : IMarketDatum
    {

        #region IMarketDatum Members


        public List<IRawMarketDatum> RawMarketData
        {
            get { return new List<IRawMarketDatum> { RawPrice }; }
        }

        #endregion
    }
}
