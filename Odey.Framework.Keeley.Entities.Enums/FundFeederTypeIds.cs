using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FundFeederTypeIds
    {
        [EnumMember]
        Irish = 1,

        [EnumMember]
        Delaware = 2,
        [EnumMember]
        Cayman = 3
    }
     
}
