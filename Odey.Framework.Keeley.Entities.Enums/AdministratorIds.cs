using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
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
        ValueTrack = 6557
    }
}
