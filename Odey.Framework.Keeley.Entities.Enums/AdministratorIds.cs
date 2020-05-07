using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum AdministratorIds
    {
        [EnumMember]
        RBCDexia = 4356,
        [EnumMember]
        CapitaUK = 4514,
        [EnumMember]
        Quintillion = 6308,
        [EnumMember]
        CapitaIRE = 6052,
        [EnumMember]
        NucleusFundPlatform = 6444,
        [EnumMember]
        TransactFundPlatform = 6453,
        [EnumMember]
        CofundsFundPlatform = 6465,
        [EnumMember]
        OdeyWealthFundPlatform = 6467,
        [EnumMember]
        InvestmentFundsDirectFundPlatform = 6475,
        [EnumMember]
        Pulse = 6557,
        [EnumMember]
        UniversalInvestment = 7893,
        [EnumMember]
        ValueTrac = 8936,
        [EnumMember]
        Attrax = 9821,
        [EnumMember]
        Clearstream = 10201,
        [EnumMember]
        RaymondJames = 8664
    }
}
