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
        [Description("Focus List")]
        [EnumMember]
        FocusList = 1,
        
        [Description("Negative Balance")]
        [EnumMember]
        NegativeBalance = 2,

        [Description("Previous Holding")]
        [EnumMember]
        PreviousHolding = 3,

        [Description("Expired")]
        [EnumMember]
        Expired = 4,

        [Description("Other")]
        [EnumMember]
        Other = 5,

        [Description("Invalid")]
        [EnumMember]
        Invalid = 6,
        
        [Description("Restricted List")]
        [EnumMember]
        RestrictedList = 7,


        [Description("Research Note within 5 days")]
        [EnumMember]
        ResearchNoteWithin5Days = 7,
    }
}
