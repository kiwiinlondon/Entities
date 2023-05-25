using System;
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
        [EnumMember]
        SRRI = 3,
        [EnumMember]
        ValuationTime = 4,
        [EnumMember]
        Intranet =5,
        [EnumMember]
        AlternateBeta = 6
    }
}
