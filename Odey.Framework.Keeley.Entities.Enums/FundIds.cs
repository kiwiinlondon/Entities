﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FundIds
    {
        [EnumMember]
        OEI = 741,
        [EnumMember]
        OEIMAC = 4927,
        [EnumMember]
        GIANO94 = 4849,
        [EnumMember]
        OUAR = 3609,
        [EnumMember]
        DYSS = 5591,
        [EnumMember]
        MR11 = 5590,
        [EnumMember]
        OPUS = 5328,
        [EnumMember]
        OCE = 5082,
        [EnumMember]
        PORT = 5330,
        [EnumMember]
        VITR = 5333
    }
}
