using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum OdeyIndustryIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Fund = 689,
        [EnumMember]
        Index = 691,
        [EnumMember]
        Unknown = 522
        
    }
}
