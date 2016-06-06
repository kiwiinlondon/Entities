using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum PortfolioAggregationLevelIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        TradeDate = 2,
        [EnumMember]
        SettlementDate = 3
    }
}
