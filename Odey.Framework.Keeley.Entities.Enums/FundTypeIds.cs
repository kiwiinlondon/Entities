using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FundTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Hedge =	1,
        [EnumMember]
        Retail = 4,
        [EnumMember]
        Wealth = 5,
        [EnumMember]
        Segregated = 6,
        [EnumMember]
        ShareClass	= 7,
        [EnumMember]
        Institutional =	9,
        [EnumMember]
        UCITS =10,
        [EnumMember]
        ManagedDailyDealing = 11,
        [EnumMember]
        Virtual=12,
        [EnumMember]
        WealthSegregated=13,
        [EnumMember]
        LongShortSegregated = 14,
    }
}
