using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ClientIds
    {
        [EnumMember]
        Dummy = 9706,
        [EnumMember]
        Staff = 7425
    }
}
