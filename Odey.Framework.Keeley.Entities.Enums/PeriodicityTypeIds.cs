using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
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
