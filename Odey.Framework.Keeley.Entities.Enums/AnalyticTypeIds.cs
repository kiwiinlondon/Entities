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
        LiquidityWeightedAverageNumberOfDays=2,
        [EnumMember]
        LiquidityTotalHaircutPercentNAV=3,
        [EnumMember]
        LiquidityValueGreaterMaxDailyLimitPercentNAV=4
    }
}

