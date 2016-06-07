using System;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum MatchedStatusIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Matched = 1,
        [EnumMember]
        Notified = 2,
        [EnumMember]
        Rejected = 3,
        [EnumMember]
        Broken = 4,
        [EnumMember]
        NotApplicable = 5
    }
}
