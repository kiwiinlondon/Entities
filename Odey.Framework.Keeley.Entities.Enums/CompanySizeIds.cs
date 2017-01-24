using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]           
    public enum CompanySizeIds
    {
        [EnumMember]
        [Description("Unknown")]
        Unknown = 1,


        [Description("Nano")]
        [EnumMember]
        Nano = 2,

        [Description("Micro")]
        [EnumMember]
        Micro = 3,

        [Description("Small")]
        [EnumMember]
        Small = 4,

        [Description("Mid")]
        [EnumMember]
        Mid = 5,

        [Description("Big")]
        [EnumMember]
        Big = 6,

        [Description("Mega")]
        [EnumMember]
        Mega =7

    }
}
