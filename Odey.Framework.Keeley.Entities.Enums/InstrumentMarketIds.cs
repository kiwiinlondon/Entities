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
        BBALIBOR = 11651,
        [EnumMember]
        EURIBOR = 11652,
    }
}
