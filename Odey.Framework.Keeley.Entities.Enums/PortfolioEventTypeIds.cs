using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum PortfolioEventTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        EquityTrade = 1,
        [EnumMember]
        FixedIncomeTrade = 2,
        [EnumMember]
        ProprietaryFXTrade = 3,
        [EnumMember]
        HedgingFXTrade = 4,
        [EnumMember]
        Subscription = 5,
        [EnumMember]
        Redemption = 6,
        [EnumMember]
        InternalAccounting = 7,
        [EnumMember]
        InstrumentEvent = 8,
        [EnumMember]
        CashFromTrading = 9,
        [EnumMember]
        FutureTrade = 10,
        [EnumMember]
        CashEquivalentTrade = 11,
        [EnumMember]
        OptionTrade = 12
    }
}

