using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum IdentifierTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        IsoCode = 1,
        [EnumMember]
        FMOrgId = 2,
        [EnumMember]
        BBCompanyCode=3,
        [EnumMember]
        FMInstClass=4,
        [EnumMember]
        FMInstId=5,
        [EnumMember]
        FMSecId=6,
        [EnumMember]
        Isin=7,
        [EnumMember]
        Sedol=8,
        [EnumMember]
        BBTicker=9,
        [EnumMember]
        FMStrategy=10,
        [EnumMember]
        FMTradType=11,
        [EnumMember]
        FMContId=12
    }
}
