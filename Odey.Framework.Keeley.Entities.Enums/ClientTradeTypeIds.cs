using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ClientTradeTypeIds
    {
        [EnumMember]
        Normal = 1,
        [EnumMember]
        Transfer = 2
    }
}
