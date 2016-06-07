using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum BloombergYellowKeyIds
    {
        [EnumMember]
        Equity	= 1,
        [EnumMember]
        GovernmentBond	= 2,
        [EnumMember]
        CorporateBond	= 3,
        [EnumMember]
        PreferenceShare = 4,
        [EnumMember]
        Currency = 5,
        [EnumMember]
        Commodity = 6,
        [EnumMember]
        Index=7
    }
}
