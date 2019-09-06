using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum TaskAlertConfigurationTypeIds
    {
        [EnumMember]
        TimeoutLength =2,
        [EnumMember]
        WhoToAlert=3,
        [EnumMember]
        RepeatAlertTimespan = 4
    }
}
