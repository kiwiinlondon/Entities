using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FundIds
    {
        [EnumMember]
        OEI=741,
        [EnumMember]
        OEIMAC=4927,
        [EnumMember]
        GIANO94 = 4849
    }
}
