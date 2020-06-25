using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum RawFinancingTypeIds
    {
        [EnumMember]
        Financing	= 1,
        [EnumMember]
        Borrow	= 2,
        [EnumMember]
        Overborrow	= 3,
        [EnumMember]
        Margin =4,
        [EnumMember]
        Cash =5,
        [EnumMember]
        RehypothecationEarning =6,
        [EnumMember]
        CashInterestCredit =8,
        [EnumMember]
        CashInterestDebit =9,
        [EnumMember]
        MarginRequirement =10,
        [EnumMember]
        Rehypothecation =11,
        [EnumMember]
        OverborrowOffset = 12
    }
}
