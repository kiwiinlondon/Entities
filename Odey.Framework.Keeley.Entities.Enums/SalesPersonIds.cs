using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum SalesPersonIds
    {
        [EnumMember]
        [Description("Tom Trowbridge")]
        TomTrowbridge = 109,

        [EnumMember]
        [Description("Stefan Wey")]
        StefanWey = 108,

        [EnumMember]
        [Description("Peter Wyllie")]
        PeterWyllie = 107,

        [EnumMember]
        [Description("Orlando Montagu")]
        OrlandoMontagu = 94,

        [EnumMember]
        [Description("Candida Lahaise")]
        CandidaLahaise = 106,

        [EnumMember]
        [Description("Andrew Sandler")]
        AndrewSandler = 105,

        [EnumMember]
        [Description("Lodewijk Van Moorsel")]
        LodewijkVanMoorsel = 141,

        [EnumMember]
        [Description("James Kostoris")]
        JamesKostoris = 135,

        [EnumMember]
        [Description("Woody Stileman")]
        WoodyStileman = 161,

        [EnumMember]
        [Description("OWM (UK)")]
        OwmUk = 218,

        [EnumMember]
        [Description("OWM (CI)")]
        OwmCi = 219,

        [EnumMember]
        [Description("Crispin Odey")]
        CrispinOdey = 43,
    }
}
