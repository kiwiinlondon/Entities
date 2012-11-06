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
        OEIGBPASHARECLASS = 5505,
        [EnumMember]
        OEIGBPBSHARECLASS = 5507,
        [EnumMember]
        OEIUSDSHARECLASS = 5508,
        [EnumMember]
        OEIEURSHARECLASSMAC = 5584,
        [EnumMember]
        OEIGBPAMANSHARECLASS = 5766,       
        [EnumMember]
        OEIEURMSHARECLASS = 6051,
        [EnumMember]
        OEIMAC = 4927,
        [EnumMember]
        OEIMACGBPASHARECLASS = 5512,
        [EnumMember]
        OEIMACGBPBSHARECLASS = 5513,
        [EnumMember]
        OEIMACGBPBMSHARECLASS = 5905,        
        [EnumMember]
        GIANO94 = 4849,
        [EnumMember]
        OUAR = 3609,
        [EnumMember]
        DYSS = 5591,
        [EnumMember]
        DYSSGBPISHARECLASS = 5747,
        [EnumMember]
        DYSSGBPMSHARECLASS = 5749,
        [EnumMember]
        DYSSGBPRSHARECLASS = 5750,
        [EnumMember]
        DYSSEURSHARECLASS = 5901,
        [EnumMember]
        MR11 = 5590,
        [EnumMember]
        MR11GBPSHARECLASS = 5746,
        [EnumMember]
        MR11USDSHARECLASS = 5902,
        [EnumMember]
        MR11GBPMSHARECLASS = 5903,
        [EnumMember]
        MR11EURMSHARECLASS = 5904,
        [EnumMember]
        OPUS = 5328,
        [EnumMember]
        OCE = 5082,
        [EnumMember]
        PORT = 5330,
        [EnumMember]
        VITR = 5333,
        [EnumMember]
        FEBT = 5084,
        [EnumMember]
        FEBX = 5313,
        [EnumMember]
        FGT = 5314,
        [EnumMember]
        GARD = 5315,
        [EnumMember]
        BARC = 4963,
        [EnumMember]
        BARF = 4964,
        [EnumMember]
        TPTL = 5332,
        [EnumMember]
        BEST = 4965,
        [EnumMember]
        OBID = 5325,
        [EnumMember]
        CFNO = 4966,
        [EnumMember]
        MMAG = 5987,
        [EnumMember]
        OSYN = 5329,
        [EnumMember]
        CAC = 2485,
        [EnumMember]
        JLEG = 5732,
        [EnumMember]
        ALEG = 4930,
        [EnumMember]
        OEAF = 5326,
        [EnumMember]
        OF = 5592,
        [EnumMember]
        OPE = 5327,
        [EnumMember]
        ATLAS = 6053
    }
}
