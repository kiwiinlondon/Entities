﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FileGroupTypeIds
    {
        [EnumMember]
        Client=1,
        [EnumMember]
        Simple=3
    }
}
