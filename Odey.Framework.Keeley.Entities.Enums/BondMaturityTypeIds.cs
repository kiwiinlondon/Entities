﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum BondMaturityTypeIds
    {
        [EnumMember]
        Normal = 1,
        [EnumMember]
        Convertible = 2,
        [EnumMember]
        Perpetual = 3,
        [EnumMember]
        Callable = 4,
        [EnumMember]
        Sinkable = 5
    }
}
