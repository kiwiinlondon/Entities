using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum PnlTypeIds
    {
        [EnumMember]
        ManagementFee = 1,
        [EnumMember]
        PerformanceFee = 2,
        [EnumMember]
        OtherGeneralLedger = 3,
        [EnumMember]
        UnmatchedInstrument = 4,
        [EnumMember]
        Default = 5,
        [EnumMember]
        OtherShareClassSpecific = 6,
        [EnumMember]
        FXOptionExposure = 7,
        [EnumMember]
        AdditionalCounterparty = 8,
        [EnumMember]
        Currency = 9,
        [EnumMember]
        CFDFutureCurrencyOffset = 10,
        [EnumMember]
        Commission = 11,
        [EnumMember]
        Financing = 12,
        [EnumMember]
        FinancingSpread = 13,
        [EnumMember]
        FuturesClearing = 14,
        [EnumMember]
        OtherTradingExpenses = 15,
        [EnumMember]
        Overborrow = 16,
        [EnumMember]
        MarginInterest = 17,
        [EnumMember]
        CashInterest = 18
    }
}
