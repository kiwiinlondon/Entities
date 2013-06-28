
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
        Beta = 7,
        [EnumMember]
        IndicativeFundPerformance =8,
        [EnumMember]
        OptionDelta = 9,
        [EnumMember]
        HedgeRatio = 10
    }
}

