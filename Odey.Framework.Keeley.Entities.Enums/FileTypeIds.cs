using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FileTypeIds
    {
        [EnumMember]
        DaiwaPAStandardExtract = 1,
        [EnumMember]
        CapitaPositionFile = 2,
        [EnumMember]
        DaiwaPositionFile = 3,
        [EnumMember]
        EFAPositionFile = 4,
        [EnumMember]
        NorthernTrustFile = 5,
        [EnumMember]
        RBCAccountRegistry = 6,
        [EnumMember]
        RBCAccountTrades = 7,
        [EnumMember]
        JPMorganPositionFile = 8,
        [EnumMember]
        CapitaUKAccountRegistry = 9,
        [EnumMember]
        CapitaUKAccountTrades = 10,
        [EnumMember]
        QuintillionAccountRegistry = 11,
        [EnumMember]
        QuintillionAccountTrades = 12,
        [EnumMember]
        CapitaIREAccountRegistry = 13,
        [EnumMember]
        CapitaIREAccountTrades = 14,
        [EnumMember]
        JPMorganJLegFile=15,
        [EnumMember]
        QuintillionEQFactorHWMPrice = 16,
        [EnumMember]
        CapitaUKClientTransfers = 17,
        [EnumMember]
        FailedTrades = 18,

        [EnumMember]
        QuintillionPositionFile = 19,

        [EnumMember]
        QuintillionIndicativePrices = 20,
        
        [EnumMember]
        RiskReportFigures = 21,

        [EnumMember]
        QuintillionClientTransfers = 22,

        [EnumMember]
        ArkusRiskReport = 23,
        [EnumMember]
        OBIDPrices = 24,
        [EnumMember]
        BestPrices = 25,
        [EnumMember]
        NucleusClientHoldings = 26,
        [EnumMember]
        TransactClientHoldings = 28,
        [EnumMember]
        CofundsClientHoldings = 30,
        [EnumMember]
        OdeyWealthClientHoldings = 31,
        [EnumMember]
        InvestmentFundsDirectClientHoldings = 32,
        [EnumMember]
        EFAFundPriceFile = 33,
        [EnumMember]
        PulseTradeFile = 34,
        [EnumMember]
        QuintillionNav = 35,
        [EnumMember]
        PulsePositionFile = 36,
        [EnumMember]
        PulseTradesInitialLoad = 37,
        [EnumMember]
        ManagerPriceTarget = 38,
    }
}
