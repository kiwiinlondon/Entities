﻿using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum CurrencyIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 1        
    }
}