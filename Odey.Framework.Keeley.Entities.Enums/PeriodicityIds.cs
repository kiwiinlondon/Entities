using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
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
        LastDayOfMonth = 6
    }
}
