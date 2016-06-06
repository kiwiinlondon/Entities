using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum PeriodicityTypeIds
    {
        [EnumMember]
        Daily =	1,
        [EnumMember]
        DaysInMonth	= 2,
        [EnumMember]
        DaysOfWeekInMonth =	3,
        [EnumMember]
        DaysOfWeek = 4,
        [EnumMember]
        DaysInQuarter =5
    }
}
