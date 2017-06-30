using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum AttributionSourceIds
    {
        [EnumMember]
        Master = 1,
        [EnumMember]
        Valuation = 2
    }
}
