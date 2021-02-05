using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{

    [DataContract]
    public enum FundStructureIds
    {
        [EnumMember]
        Ucits = 1,       
        [EnumMember]
        QIAIF = 4,
        [EnumMember]
        CaymanOEIC = 5,          
        [EnumMember]
        Segregated	=7,
        [EnumMember]
        ICVC = 8
    }
}
