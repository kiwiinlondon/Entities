
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

        [EnumMember]
        Beta90DayDaily = 7,
        
        [EnumMember]
        IndicativeFundPerformance =8,
        
        [EnumMember]
        OptionDelta = 9,
        
        [EnumMember]
        HedgeRatio = 10,
        
        [EnumMember]
        BBVolumeAverage30DValue = 11,
        
        [EnumMember]
        VaR = 12,
        
        [EnumMember]
        Beta2YearDaily = 13,

        [EnumMember]
        BetaFund2YearWeighted = 14,

        [EnumMember]
        BetaFund90DayWeighted = 15,
    }
}

