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
        RegionIso = 1,
        [EnumMember]
        CountryIso = 2
    }
}
