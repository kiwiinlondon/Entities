using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum OdeyIndustryIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Fund = 689,
        [EnumMember]
        Index = 691,
        [EnumMember]
        Unknown = 522,
        [EnumMember]
        FundBanks =	698,
        [EnumMember]
        FundFinancialServices = 699,
        [EnumMember]
        FundREITS = 700,
        [EnumMember]
        FundInsurance = 701,
        [EnumMember]
        FundUtility	= 702,
        [EnumMember]
        FundIndustrial = 703,
        [EnumMember]
        FundMunicipal = 704,
        [EnumMember]
        Other = 376

    }
}
