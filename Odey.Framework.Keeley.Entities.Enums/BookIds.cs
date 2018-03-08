using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum BookIds
    {
        [EnumMember]
        OuarAC = 176,
        [EnumMember]
        ArffAC = 177,
        [EnumMember]
        BvffAC = 189,
        [EnumMember]
        DevmAC = 197,
        [EnumMember]
        FdxhAC = 198,
        [EnumMember]
        OEI =5
    }
}