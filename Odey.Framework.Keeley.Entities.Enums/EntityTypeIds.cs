﻿using System.Runtime.Serialization;

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
        Analytic = 27

    }
}
