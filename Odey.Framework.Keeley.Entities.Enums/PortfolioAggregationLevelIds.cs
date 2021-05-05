using System;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum PortfolioAggregationLevelIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        TradeDate = 2,
        [EnumMember]
        SettlementDate = 3,
        [EnumMember]
        ValuationDate = 4
    }
}
