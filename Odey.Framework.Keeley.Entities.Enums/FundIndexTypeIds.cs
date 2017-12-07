﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FundIndexTypeIds
    {
        [EnumMember]
        Relative = 1,
        [EnumMember]
        Beta = 2,
    }
}