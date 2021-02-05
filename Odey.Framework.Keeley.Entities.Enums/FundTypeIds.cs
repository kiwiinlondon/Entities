using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FundTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Hedge =	1,
        [EnumMember]
        LongOnly = 4,
        [EnumMember]
        Segregated = 6,
        [EnumMember]
        ShareClass	= 7,        
        [EnumMember]
        LongShort =10,        
        [EnumMember]
        Virtual=12        
    }
}
