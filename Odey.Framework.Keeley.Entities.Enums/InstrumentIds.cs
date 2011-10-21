using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    public enum InstrumentIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        USWheat = 22500,
        [EnumMember]
        USCotton = 22501
    }
}
