using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FMIndustryIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Fund = 687,
        [EnumMember]
        Unknown = 279
        
    }
}
