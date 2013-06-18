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
        DexiaAccountTrades = 7,
        [EnumMember]
        JPMorganPositionFile = 8,
        [EnumMember]
        CapitaUKAccountRegistry = 9,
        [EnumMember]
        CapitaUKAccountTrades = 10,
        [EnumMember]
        DaiwaAccountRegistry = 11,
        [EnumMember]
        DaiwaAccountTrades = 12,
        [EnumMember]
        CapitaIREAccountRegistry = 13,
        [EnumMember]
        CapitaIREAccountTrades = 14,
        [EnumMember]
        JPMorganJLegFile=15,
        [EnumMember]
        DaiwaEQFactorHWMPrice = 16,
        [EnumMember]
        CapitaUKClientTransfers = 17,
        [EnumMember]
        FailedTrades = 18,

        [EnumMember]
        QuintillionPositionFile = 19,

        [EnumMember]
        QuintillionIndicativePrices = 20,
    }
}
