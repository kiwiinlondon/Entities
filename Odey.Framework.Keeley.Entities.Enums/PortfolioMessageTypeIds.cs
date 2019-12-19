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
        Event = 3,
        [EnumMember]
        RebuildPosition = 4,
        [EnumMember]
        RevaluePosition = 5,
        [EnumMember]
        RollFund = 6,
        [EnumMember]
        RecalculateFundTotal = 7
    }
}
