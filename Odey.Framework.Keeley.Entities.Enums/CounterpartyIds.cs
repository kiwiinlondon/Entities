using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum CounterpartyIds
    {
        [EnumMember]
        Unknown = 3762,
        [EnumMember]
        DexiaFX = 4954,
        [EnumMember]
        GSFX = 7557,
        [EnumMember]
        JPML = 3657,
        [EnumMember]
        JPFI = 10813,
    }
}
