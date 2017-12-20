using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum MessageTypeIds
    {        
        [EnumMember]
        [Description("Portfolio")]
        Portfolio =1,
        [EnumMember]
        [Description("AttributionPnl")]
        AttributionPnl =2,
        [EnumMember]
        [Description("Portfolio Rollover")]
        PortfolioRollover =3
    }
}
