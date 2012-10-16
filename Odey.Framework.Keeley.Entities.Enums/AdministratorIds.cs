using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum AdministratorIds
    {
        [EnumMember]
        RBCDexia = 4356,
        [EnumMember]
        CapitaUK = 4514,
        [EnumMember]
        Daiwa = 3845,
        [EnumMember]
        CapitaIRE = 6052
    }
}
