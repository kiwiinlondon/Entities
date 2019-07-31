using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum TaskNotCompleteBehaviourIds
    {
        [EnumMember]
        Skip = 1,
        [EnumMember]
        QueueOnce = 2,
        [EnumMember]
        Exception = 3,
        [EnumMember]
        AlwaysQueue = 4,
        [EnumMember]
        IgnoreErrored = 5
    }
}
