using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum TaskStateTypeIds
    {
        [EnumMember]
        Complete = 1,               
        [EnumMember]
        Errored = 3,
        [EnumMember]
        AwaitingDependency = 4,
        [EnumMember]
        NeverRun = 5,
        [EnumMember]
        Queued = 6,
        [EnumMember]
        DependentTaskRunning = 7
    }
}
