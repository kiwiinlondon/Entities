﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum AccountIds
    {
        [EnumMember]
        VT = 108,

        [EnumMember]
        WSEG = 134,

        [EnumMember]
        ITR = 135,
    }
}
