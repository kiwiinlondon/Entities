using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum EntityTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        TradeEvent = 1,
        [EnumMember]
        Fund = 7,
        [EnumMember]
        Counterparty = 8,
        [EnumMember]
        Currency = 9,
        [EnumMember]
        InstrumentMarket = 10,
        [EnumMember]
        InstrumentClass = 11,
        [EnumMember]
        ExtractEntity = 12,
        [EnumMember]
        MatchedStatus = 13,
        [EnumMember]
        InstrumentEvent = 14,
        [EnumMember]
        CapitalEvent = 15,
        [EnumMember]
        FXTradeEvent = 16,
        [EnumMember]
        InternalAccountingEvent = 17,
        [EnumMember]
        Price = 18,
        [EnumMember]
        FXRate = 19,
        [EnumMember]
        MatchingEngineOutput = 20,
        [EnumMember]
        Book = 22,
        [EnumMember]
        Industry = 23,
        [EnumMember]
        Sector = 24,
        [EnumMember]
        Country = 25,
        [EnumMember]
        Region = 26,
        [EnumMember]
        Analytic = 27,
        [EnumMember]
        DerivedAssetClass = 28,
        [EnumMember]
        LegalEntity	= 29,
        [EnumMember]
        Market = 31,
        [EnumMember]
        Issuer = 32,
        [EnumMember]
        Instrument = 33,
        [EnumMember]
        InstrumentEventType = 34,
        [EnumMember]
        EntityRankingScheme = 35,
        [EnumMember]
        EntityRankingSchemeItem = 36,
        [EnumMember]
        Custodian = 37,
        [EnumMember]
        ChargeType = 38,
        [EnumMember]
        BuySellReason = 39,
        [EnumMember]
        ApplicationUser = 40,
        [EnumMember]
        Account = 41,
        [EnumMember]
        Client = 44,
        [EnumMember]
        IndexConstituent = 46,
        [EnumMember]
        DayCountConvention = 49,
        [EnumMember]
        RollConvention = 50
    }
}

