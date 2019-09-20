using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum PortfolioMessageTypeIds
    {
        [EnumMember]
        MarketData = 1,
        [EnumMember]
        EventChange = 3,
        [EnumMember]
        RebuildPosition = 4,
    }
}
