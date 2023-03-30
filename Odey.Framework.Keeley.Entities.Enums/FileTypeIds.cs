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
        JPMorganJLegFile = 15,
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
        [EnumMember]
        ClientNomineeAccount = 39,
        [EnumMember]
        PeerGroupRankings = 40,
        [EnumMember]
        FactsetMonthlyContribution = 41,
        [EnumMember]
        QuintillionPositionFilePortfolioLoadOnly = 42,
        [EnumMember]
        ClientTrail = 43,
        [EnumMember]
        MarketDataControlFile = 44,
        [EnumMember]
        CSAVotedResearchPayments = 45,
        [EnumMember]
        BloombergCfdError = 46,
        [EnumMember]
        BloombergPositionError = 47,
        [EnumMember]
        BloombergPositionReconciliation = 48,
        [EnumMember]
        BonyPositionFile = 49,
        [EnumMember]
        BloombergFactorExposures = 53,
        [EnumMember]
        BloombergFactorContribution = 54,
        [EnumMember]
        BloombergVaR = 55,
        [EnumMember]
        BloombergWeights = 56,
        [EnumMember]
        PortIndexPrices = 57,
        [EnumMember]
        FactsetBenchmarkWeights = 58,
        [EnumMember]
        OfIndexPrices = 59,
        [EnumMember]
        AttraxClientHoldings = 60,
        [EnumMember]
        BloombergOOFReferenceAsset = 62,
        [EnumMember]
        JPMSwapFinancing = 63,
        [EnumMember]
        UBSSwapFinancing = 64,
        [EnumMember]
        MSSwapFinancing = 65,
        [EnumMember]
        PortPriceIndexMorningstar = 66,
        [EnumMember]
        ArkusRiskAnalytic = 67,
        [EnumMember]
        GSSwapFinancing = 68,
        [EnumMember]
        BAMLSwapFinancing = 69,
        [EnumMember]
        GSOrdFinancing = 70,
        [EnumMember]
        MSOrdFinancing = 71,
        [EnumMember]
        MSCashInterestFinancing = 72,
        [EnumMember]
        UBSRehypothecationFinancing = 73,
        [EnumMember]
        GSRehypothecationFinancing = 74,
        [EnumMember]
        MSRehypothecationFinancing = 75,
        [EnumMember]
        ClearstreamClientHoldings = 76,
        [EnumMember]
        UBSMarginRequirements= 77,
        [EnumMember]
        GSCashInterestFinancing = 78,
        [EnumMember]
        JPMCashInterestFinancing = 79,
        [EnumMember]
        RaymondJamesClientHoldings=80,
        [EnumMember]
        UBSCashInterestFinancing = 81,
        [EnumMember]
        MSMarginRequirements = 82,
        [EnumMember]
        GSMarginRequirements = 83,
        [EnumMember]
        JPMMarginRequirements = 84,
        [EnumMember]
        BAMLCashInterestFinancing = 85,
        [EnumMember]
        MSOverborrowOffset = 86,
        [EnumMember]
        QuintillionEstimatedClientTrades= 87,
        [EnumMember]
        JPMMatchedTrades = 88,
        [EnumMember]
        JPMOrdFinancing = 89,
        [EnumMember]
        JPMCashInterestFinancingOEIAndMAC = 90,
        [EnumMember]
        RBCLoansAndCollateral = 91,
        [EnumMember]
        RBCLoanRevenue = 92,
        [EnumMember]
        SegregatedAccountNavFile=93,
        [EnumMember]
        JPMIRSPrice = 94,
        [EnumMember]
        JPMCustody = 95,
        [EnumMember]
        JPMCustodySwap = 96,
        [EnumMember]
        MSCustody = 97,
        [EnumMember]
        BAMLCustodySwap = 98,
        [EnumMember]
        JPMMargin = 99,
        [EnumMember]
        WealthStaffHoldings = 100,
    }
}
