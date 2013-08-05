
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
 [DataContract]
    public enum BetaTypeIds
    {
        [EnumMember]
        NINETY_DAY_DAILY_BETA = 1,
        [EnumMember]
        TWO_YEAR_DAILY_BETA = 2,
    }
}

