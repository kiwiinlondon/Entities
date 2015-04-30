using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]

    public enum PADealingRejectionReasonsIds
    {
        [Description("Restricted List")]
        [EnumMember]
        RestrictedList = 1,

        [Description("Focus List")]
        [EnumMember]
        FocusList = 2,

        [Description("Negative Balance")]
        [EnumMember]
        NegativeBalance = 3,

        [Description("Previous Holding")]
        [EnumMember]
        PreviousHolding = 4,

        [Description("Expired")]
        [EnumMember]
        Expired = 5,

        [Description("Other")]
        [EnumMember]
        Other = 6,
        
    }
}
