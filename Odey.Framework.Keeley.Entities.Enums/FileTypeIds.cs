using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FileTypeIds
    {
        [EnumMember]
        DaiwaPAStandardExtract = 1,
        [EnumMember]
        CapitaPositionFile = 2,
        [EnumMember]
        DaiwaPositionFile = 3,
        [EnumMember]
        EFAPositionFile = 4,
        [EnumMember]
        NorthernTrustFile = 5,
        [EnumMember]
        DexiaAccountRegistry = 6,
        [EnumMember]
        DexiaAccountTrades = 7
    }
}
