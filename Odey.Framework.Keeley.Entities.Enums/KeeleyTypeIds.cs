using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum KeeleyTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Region = 1,
        [EnumMember]
        Country = 2,
        [EnumMember]
        Issuer = 3,
        [EnumMember]
        Exchange = 4,
        [EnumMember]
        LegalEntity = 5
    }
}
