﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum InvestmentGuidelineTypeGroupIds
    {
        [EnumMember]
        InternalInvestmentGuidelines	= 1,
        [EnumMember]
        ProspectusLimits	=2,
        [EnumMember]
        UCITSRules	=3
    }
}
