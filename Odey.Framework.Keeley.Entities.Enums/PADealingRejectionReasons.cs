using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]

    public enum PADealingRejectionReasons
    {
        [Description("Restricted List")]
        [EnumMember]
        RestrictedList = 1,

        [Description("Focus List")]
        [EnumMember]
        FocusList = 2,

        [Description("Other")]
        [EnumMember]
        Other = 3,
        
    }
}
