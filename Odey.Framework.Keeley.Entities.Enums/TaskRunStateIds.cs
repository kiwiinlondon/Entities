using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum TaskRunStateIds
    {
        [EnumMember]
        Running = 1,
        [EnumMember]
        Queued = 2,
        [EnumMember]
        Errored = 3,
        [EnumMember]
        Complete = 4
    } 
}
