using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum SundryTypeIds
    {
        [EnumMember]
        ManagementFee = 1,
        [EnumMember]
        PerformanceFee = 2,
        [EnumMember]
        OtherGeneralLedger = 3,
        [EnumMember]
        UnmatchedInstrument = 4,
    }
}
