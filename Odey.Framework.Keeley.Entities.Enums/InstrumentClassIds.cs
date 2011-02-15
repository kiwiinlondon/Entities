﻿using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum InstrumentClassIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        All=1,
        [EnumMember]
        Equity = 2,
        [EnumMember]
        Currency = 3
    }
}
