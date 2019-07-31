using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{

    [DataContract]
    public enum TaskAlertTypeIds
    {
        [EnumMember]    
        OnStart = 1,
        [EnumMember]
        OnError = 2,
        [EnumMember]
        OnCompletion = 3,
        [EnumMember]
        OnTimeout = 4,
        [EnumMember]
        OnWarning = 5
    }
}
