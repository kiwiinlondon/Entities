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
        [DataMember]
        RBCDexia = 4356,
        [DataMember]
        Capita =4514,
        [DataMember]
        Daiwa = 3845
    }
}
