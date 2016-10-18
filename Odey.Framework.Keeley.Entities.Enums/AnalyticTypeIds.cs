﻿
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
 [DataContract]
    public enum AnalyticTypeIds
    {
        [EnumMember]
        None=0,
        
        [EnumMember]
        BBVolumeAverage30D = 1,
        
        [EnumMember]
        LiquidityWeightedAverageNumberOfDays=2,
        
        [EnumMember]
        LiquidityNonLiquidatedPercentNAV=3,
        
        [EnumMember]
        LiquidityValueGreaterMaxDailyLimitPercentNAV=4,
        
        [EnumMember]
        LiquidityHaircutPercentNAV=5,
        
        [EnumMember]
        SharesOutstanding = 6,

        /// <summary>
        /// currently 60 day daily
        /// </summary>
        [EnumMember]
        BetaShortTerm = 7, 
        
        [EnumMember]
        IndicativeFundPerformance =8,
        
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
        FundPeerGroupRanking3Y=23,

        [EnumMember]
        VaR20DaysMixedModel = 25,

        [EnumMember]
        LiquidityHaircutPercentValue = 26,

        /// <summary>
        /// stored in EntityAnalytic
        /// under EntityType counterparty, sub entity type instrumenet market with reference date being trade date (no time)
        /// </summary>
        [EnumMember]
        IntervalVolumePercent = 27,

        /// <summary>
        /// stored in EntityAnalytic
        /// under EntityType counterparty, sub entity type instrumenet market with reference date being trade date (no time)
        /// </summary>
        [EnumMember]
        ArrivalPrice = 28,

        /// <summary>
        /// stored in EntityAnalytic
        /// under EntityType counterparty, sub entity type instrumenet market with reference date being trade date (no time)
        /// </summary>
        [EnumMember]
        IntervalVWAP = 29,
    }
}

