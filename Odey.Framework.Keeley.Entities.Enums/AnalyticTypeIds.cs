
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum AnalyticTypeIds
    {
        [EnumMember]
        None = 0,

        [EnumMember]
        BBVolumeAverage30D = 1,

        [EnumMember]
        LiquidityWeightedAverageNumberOfDays = 2,

        [EnumMember]
        LiquidityNonLiquidatedPercentNAV = 3,

        [EnumMember]
        LiquidityValueGreaterMaxDailyLimitPercentNAV = 4,

        [EnumMember]
        LiquidityHaircutPercentNAV = 5,

        [EnumMember]
        SharesOutstanding = 6,

        /// <summary>
        /// currently 60 day daily
        /// </summary>
        [EnumMember]
        BetaShortTerm = 7,

        [EnumMember]
        IndicativeFundPerformance = 8,

        [EnumMember]
        OptionDelta = 9,

        [EnumMember]
        HedgeRatio = 10,

        [EnumMember]
        BBVolumeAverage30DValue = 11,

        [EnumMember]
        VaR1Day = 12,

        /// <summary>
        /// currently 2 year daily
        /// </summary>
        [EnumMember]
        BetaLongTerm = 13,

        [EnumMember]
        BetaFundShortTermWeightedNetEquitiesOnly = 14,

        [EnumMember]
        BetaFundShortTermWeightedGrossEquitiesOnly = 15,

        /// <summary>
        /// Currently Sep 2001 September 11th Scenario.
        /// From Arkus Risk Report
        /// </summary>
        [EnumMember]
        CompositeStressTest = 16,

        [EnumMember]
        IndexRatio = 17,

        [EnumMember]
        LiquidityHaircutPercentNAVFirm = 18,

        [EnumMember]
        VaR20Day = 19,

        [EnumMember]
        PricingDistribution = 20,

        [EnumMember]
        VaR1DayMixedModel = 21,
        [EnumMember]
        FundPeerGroupRanking1Y = 22,

        [EnumMember]
        FundPeerGroupRanking3Y = 23,

        [EnumMember]
        VaR20DaysMixedModel = 25,

        [EnumMember]
        LiquidityHaircutPercentValue = 26,

        [EnumMember]
        Yield = 30,

        [EnumMember]
        InflationAssumption = 31,

        [EnumMember]
        MarketCapitalisationUSD = 39,

        [EnumMember]
        OfficialSRRI = 40,

        [EnumMember]
        CalculatedSRRI = 41,

        [EnumMember]
        DailyRiskPerformanceAlertLimit = 42,

        [EnumMember]
        DailyRiskPerformanceTriggerLimit = 43,
    }
}

