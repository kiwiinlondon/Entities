using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum EntityRankingSchemeItemIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        ManualPrice = 1,
        [EnumMember]
        LastTradePrice = 2,
        [EnumMember]
        TradePrice = 3,
        [EnumMember]
        UnderlyingClosePrice=4,
        [EnumMember]
        ClosePrice = 5,
        [EnumMember]
        UnderlyingLastTradePrice = 7,
        [EnumMember]
        MidDiscountDollarPrice = 9,
        [EnumMember]
        XRateBidAsk = 13,
        [EnumMember]
        DummyPrice = 14,
        [EnumMember]
        AdministratorPrice = 16,
        [EnumMember]
        ManualAnalytic = 17,
        [EnumMember]
        FMAnalytic = 18,
        [EnumMember]
        DummyAnalytic = 19,
        [EnumMember]
        OdeyCalculatedAnalytic = 21,
        [EnumMember]
        ExternalAnalytic = 22,
        [EnumMember]
        OptionMidPrice = 24,
        [EnumMember]
        MidPrice = 26,
        [EnumMember]
        OdeyCalculatedPriceNav = 27,
        [EnumMember]
        OdeyCalculatedPriceOfficialNav = 28
    }
}
