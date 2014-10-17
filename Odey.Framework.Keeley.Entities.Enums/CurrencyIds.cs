using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum CurrencyIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        Euro = 2536,
        [EnumMember]
        USD = 2548,
        [EnumMember]
        GBP=2541,
        [EnumMember]
        NOK = 2544,
        [EnumMember]
        CHF = 2539,
        [EnumMember]
        AUD = 2537,
    }
}

