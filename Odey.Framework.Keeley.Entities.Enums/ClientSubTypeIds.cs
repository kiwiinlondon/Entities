using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ClientSubTypeIds
    {
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        PrivateBankAssetManager = 3,
        [EnumMember]
        PensionFunds = 4,
        [EnumMember]
        PublicSector = 5,
        [EnumMember]
        Corporate = 6,
        [EnumMember]
        NonProfit = 7,
        [EnumMember]
        SubAdvisory = 8,
        [EnumMember]
        Insurance = 9,
        [EnumMember]
        Endowment = 10,
        [EnumMember]
        MultiManager = 11,
        [EnumMember]
        Charity = 12,
        [EnumMember]
        FundOfFunds = 13,
        [EnumMember]
        Staff = 14,
        [EnumMember]
        PrivateClient = 15,
        [EnumMember]
        IFA = 16,
        [EnumMember]
        FamilyOffice = 17,
        [EnumMember]
        FundOfFundsHedge = 18,
        [EnumMember]
        OdeyHoldingsAG = 19, 
        [EnumMember]
        SegregatedAccount = 20,
        [EnumMember]
        Institutional = 22, 
        [EnumMember]
        Trust = 23, 
        [EnumMember]
        DirectWealthManager = 24, 
        [EnumMember]
        Platform = 25, 
        [EnumMember]
        OdeyFund = 26,
    }
}
