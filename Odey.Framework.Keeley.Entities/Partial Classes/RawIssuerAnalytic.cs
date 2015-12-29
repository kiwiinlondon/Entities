using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Interfaces;

namespace Odey.Framework.Keeley.Entities
{
    partial class RawIssuerAnalytic : IRawMarketDatum
    {
        int IRawMarketDatum.RawMarketDatumId
        {
            get
            {
                return RawIssuerAnalyticId;
            }
        }




        List<IMarketDatum> IRawMarketDatum.MarketData
        {
            get { return IssuerAnalytics.ToList<IMarketDatum>(); }
        }
    }
}
