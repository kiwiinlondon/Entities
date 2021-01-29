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
        LongOnlyUcitsIV = 1,
        [EnumMember]
        LongShortUcitsIV = 2,
        [EnumMember]
        QIAIF = 4,
        [EnumMember]
        CaymanAIF = 5,
        [EnumMember]
        OdeyWealth = 6,
        [EnumMember]
        Segregated	=7
    }
}
