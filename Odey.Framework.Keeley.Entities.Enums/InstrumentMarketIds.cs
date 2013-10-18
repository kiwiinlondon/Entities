using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    public enum InstrumentMarketIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 11276,
        [EnumMember]
        BBALIBORUSD = 11651,
        [EnumMember]
        EURIBOR = 11652,
        [EnumMember]
        CacFundIndex = 11667,
        [EnumMember]
        BaifUcitsFofBalancedIndex = 11668,
        [EnumMember]
        BBALIBORGBP = 16342,
        [EnumMember]
        OBID = 9908,
        [EnumMember]
        BEST = 9902,
    }
}
