using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum MessageTypeIds
    {
        [EnumMember]
        Portfolio =1,
        [EnumMember]
        AttributionPnl=2,
        [EnumMember]
        PortfolioRollover=3
    }
}
