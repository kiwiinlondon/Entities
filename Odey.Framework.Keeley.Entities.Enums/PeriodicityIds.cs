using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum PeriodicityIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Daily = 1,
        [EnumMember]
        FirstAndFifteenthOfMonth = 2,
        [EnumMember]
        FirstOfMonth = 3,
        [EnumMember]
        EveryWednesday = 4,
        [EnumMember]
        LastDayOfQuarter = 5,
        [EnumMember]
        LastDayOfMonth = 6,
        [EnumMember]
        FundValuationDate = 8,
        [EnumMember]
        EveryFriday = 9
    }
}
