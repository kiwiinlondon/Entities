
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
 [DataContract]
    public enum RiskAnalyticTypeIds
    {

        [EnumMember]
        TotalRisk = 1,
        
        [EnumMember]
        PercentSystematicTotalRisk = 2,

        [EnumMember]
        TrackingError = 3,

        [EnumMember]
        TrackingVariance = 4,

        [EnumMember]
        PercentSystematicTrackingVariance = 5,

        [EnumMember]
        PortfolioBeta = 6,

        [EnumMember]
        UnrecognisedStocksNumber = 7,

        [EnumMember]
        UnrecognisedStocksPercentWeight = 8,

        [EnumMember]
        IlliquidStocksNumber = 9,

        [EnumMember]
        IlliquidStocksPercentWeight = 10,

        [EnumMember]
        ExcludedStocksNumber = 11,

        [EnumMember]
        WeightsGreater5PercentNumber = 12,

        [EnumMember]
        WeightsGreater10PercentNumber = 13,

        [EnumMember]
        WeightsGreater20PercentNumber = 14,

        [EnumMember]
        WeightsGreater5PercentWeight = 15,

        [EnumMember]
        WeightsGreater10PercentWeight = 16,

        [EnumMember]
        WeightsGreater20PercentWeight = 17,

        [EnumMember]
        PortfolioVarWithDerivativesPrimary = 18,

        [EnumMember]
        ImpliedLeveragePrimarySettings = 19,

        [EnumMember]
        CumulativeNumOfShortfalls = 20,

        [EnumMember]
        January1974OilPriceShock = 21,

        [EnumMember]
        Recession1981 = 22,

        [EnumMember]
        October1987StockMarketCrash = 23,

        [EnumMember]
        Recession1990 = 24,

        [EnumMember]
        SepToDec1992SterlingDevaluation = 25,

        [EnumMember]
        July1997ToJan1998AsiaCrisis = 26,

        [EnumMember]
        Aug1998RussianCrisisLTCM = 27,

        [EnumMember]
        Sep2001September11th = 28,

        [EnumMember]
        ScenarioEuropeanRecession = 29,

        [EnumMember]
        ScenarioUSRecession = 30,

        [EnumMember]
        IndexVaRPrimarySettings = 31,

        [EnumMember]
        PortfolioVarwithDerivSecondary = 32,

        [EnumMember]
        IndexVaRSecondarySettings = 33,

        [EnumMember]
        IlliquidAssets = 34,

        [EnumMember]
        ArabSpringPart2MERevolutions = 35,

        [EnumMember]
        BearishFlattening75bps = 36,

        [EnumMember]
        BearishSteepening75bps = 37,

        [EnumMember]
        BigRiseGlobalInflationExpectations = 38,

        [EnumMember]
        BullishFlatteningMinus75bps = 39,

        [EnumMember]
        BullishSteepeningMinus75bps = 40,

        [EnumMember]
        ChinaRecession = 41,

        [EnumMember]
        ConvexButterfly25bps = 42,

        [EnumMember]
        DebtCeilingQE3FlightOutUSDAndUSTs = 43,

        [EnumMember]
        GermanyHollandLeaveEURAndFormNordEuro = 44,

        [EnumMember]
        InverseButterflyMinus25bps = 45,

        [EnumMember]
        LehmanSep08OneMonthHorizon = 46,

        [EnumMember]
        LehmanSep08ThreeMonthHorizon = 47,

        [EnumMember]
        RobustNonInflationaryGrowth = 48,

        [EnumMember]
        ShortTermSpikeInEnergyMetalsAgri = 49,

        [EnumMember]
        SpanishSovereignContagion = 50,

        [EnumMember]
        USDAppreciatesBy10Percent = 51,

        [EnumMember]
        PortfolioVaRWithoutDerivPrimary = 52,

        [EnumMember]
        BloombergVaRMC99 = 54,

        [EnumMember]
        BloombergWeight = 55,

        [EnumMember]
        BloombergPartialVaRMC99 = 56,

        [EnumMember]
        BloombergCVaRMC99 = 57,

        [EnumMember]
        BloombergComponentVaRMC99 = 58,

        [EnumMember]
        BloombergVaRContributionMC99 = 59,

        [EnumMember]
        BloombergIndexVaRMC99 = 60,

        [EnumMember]
        BloombergIndexCVaRMC99 = 61,

	    [EnumMember]
	    BloombergBetaExAnte = 65,

        [EnumMember]
        BloombergTotalRisk = 66
    }
}

