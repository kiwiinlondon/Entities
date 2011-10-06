﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum EntityRankingSchemeItemIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        DummyPrice = 14,
        [EnumMember]
        PerfDBNavPrice = 16,
        [EnumMember]
        ManualAnalytic = 17,
        [EnumMember]
        FMAnalytic = 18,
        [EnumMember]
        DummyAnalytic = 19

    }
}