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
        FutureTrade = 3,
        [EnumMember]
        OptionTrade = 4,
        [EnumMember]
        CashEquivalentTrade = 5,
        [EnumMember]
        ProprietaryFXTrade = 6,
        [EnumMember]
        HedgingFXTrade = 7,
        [EnumMember]
        Subscription = 8,
        [EnumMember]
        Redemption = 9,
        [EnumMember]
        InternalAccounting = 10,
        [EnumMember]
        InstrumentEvent = 11,
        [EnumMember]
        CashFromTrading = 12,
        [EnumMember]
        Accrual = 13,
        [EnumMember]
        CashBenefit = 14,
        [EnumMember]
        PNLRoll = 15,
        [EnumMember]
        AccountTransfer = 16,
        [EnumMember]
        EnforcePosition = 17, 
        [EnumMember]
        RepoTrade = 18

    }
}

