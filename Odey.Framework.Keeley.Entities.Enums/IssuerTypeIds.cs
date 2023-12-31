﻿
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
 [DataContract]
    public enum IssuerTypeIds
    {
        
        [EnumMember]
        Default = 1,
        
        [EnumMember]
        CurrencyPair=2,

        [EnumMember]
        InterestRateSwap = 3,
        [EnumMember]
        Repo = 4,
    }
}

