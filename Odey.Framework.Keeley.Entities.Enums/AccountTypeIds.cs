using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]

    public enum AccountTypeIds
    {
        [Description("Margin")]
        [EnumMember]
        Margin = 1,

        [Description("Custody")]
        [EnumMember]
        Custody = 2,

        [Description("Swap")]
        [EnumMember]
        Swap = 3,
       
    }
}
