using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FinancingTypeIds
    {
        [EnumMember]
        EquityAndCorporateBonds = 1,
        [EnumMember]
        Swap = 2,
        [EnumMember]
        Currency = 3,
        [EnumMember]
        SwapCashProceeds = 4,
        [EnumMember]
        Margin = 5,
        [EnumMember]
        Rehypothecation = 6,
        [EnumMember]
        OverborrowOffset = 7
    }

    

}
