using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ApplicationUserIds
    {
        [EnumMember]
        Pulse = 50,
        [EnumMember]
        KeeleyServiceUser = 54,

        //add PMs and Traders
        [EnumMember]
        [Description("Crispin Odey")]
        CrispinOdey = 43,
        [EnumMember]
        DannyBeckett = 7,
        [EnumMember]
        [Description("David Bentley")]
        DavidBentley = 19,
        [EnumMember]
        FerasAlChalabi = 44,
        [EnumMember]
        FredBethell = 156,
        [EnumMember]
        FreddieLait = 62,
        [EnumMember]
        [Description("Geoff Marson")]
        GeoffMarson = 57,
        [EnumMember]
        GuyWyles = 131,
        [EnumMember]
        [Description("James Hanbury")]
        JamesHanbury = 48,
        [EnumMember]
        [Description("Jamie Grimston")]
        JamieGrimston = 80,
        [EnumMember]
        MasseyRoborough = 46,
        [EnumMember]
        MarkusRezny = 65,
        [EnumMember]
        MicheleRagazzi = 41,
        [EnumMember]
        [Description("Oliver Kelton")]
        OliverKelton = 116,
        [EnumMember]
        OrlandoMontagu = 94,
        [EnumMember]
        PaulChristophorou = 17,
        [EnumMember]
        [Description("Adrian Courtenay")]
        AdrianCourtenay = 181,
        [EnumMember]
        [Description("Sebastien Letellier")]
        SebastienLetellier = 67,
        [EnumMember]
        SurenPatel = 20,
        [EnumMember]
        TimBond = 56,
        [EnumMember]
        [Description("Paul Sheath")]
        PaulSheath = 53,
        [EnumMember]
        AdrianNorman = 114,
        [EnumMember]
        [Description("Neil Palan")]
        NeilPalan = 36,
        [EnumMember]
        IanAldous = 68,
        [EnumMember]
        MilesDempster = 99,
        [EnumMember]
        [Description("Mark Abbott")]
        MarkAbbott = 16,
        [EnumMember]
        [Description("Peter Martin")]
        PeterMartin = 47,
        [EnumMember]
        [Description("Henry Steel")]
        HenrySteel = 169,
        [EnumMember]
        [Description("Robert Marshall Lee")]
        RobertMarshallLee = 256,
    }
}
