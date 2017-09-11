using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ClientMarketingTypeIds
    {
        [EnumMember]
        Retail = 1,
        [EnumMember]
        Institutional = 2,
        [EnumMember]
        Management = 3,
        [EnumMember]
        InstitutionalOWMClientsOnly = 4,
        [EnumMember]
        RetailOWMClientsOnly = 5,
    }
}