using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Interfaces;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    partial class Analytic : IMarketDatum
    {
        #region IMarketDatum Members

        public int EntityRankingSchemeId
        {
            get { return (int)EntityRankingSchemeIds.Default; }
        }

        public List<IRawMarketDatum> RawMarketData
        {
            get { return new List<IRawMarketDatum> { RawAnalytic }; }
        }

        #endregion
    }
 
}
