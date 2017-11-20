using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum MessageTypeIds
    {
        [EnumMember]
        Portfolio = 1,
        [EnumMember]
        AttributionPnl = 2,
        [EnumMember]
        PortfolioRollover = 3,
        [EnumMember]
        LegalEntity = 4,
        [EnumMember]
        IssuerIndustry = 5,
        [EnumMember]
        Instrument = 6,
        [EnumMember]
        InstrumentMarket = 7,
        [EnumMember]
        FXRate = 8,
        [EnumMember]
        Price = 9,
        [EnumMember]
        Analytic = 10,
        [EnumMember]
        PortfolioRevalue = 11,
        [EnumMember]
        TradeEvent = 12,
        [EnumMember]
        FXTradeEvent = 13,
        [EnumMember]
        CapitalEvent = 14,
        [EnumMember]
        InstrumentEvent = 15,
        [EnumMember]
        TransferEvent = 16,
        [EnumMember]
        InternalAllocation = 17
    }
}
