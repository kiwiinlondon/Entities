using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    /// <summary>
    /// Mirrors this SQL query:
    /// select * from DenormalisedCurrency
    /// </summary>
    [TsEnum]
    [DataContract]
    public enum CurrencyIds
    {
        [EnumMember]
        None = 0,
        
        [EnumMember]
        Unknown = 1,

        [EnumMember]
        EUR = 2536,

        [EnumMember]
        Euro = 2536,

        [EnumMember]
        AUD = 2537,

        [EnumMember]
        CAD = 2538,

        [EnumMember]
        CHF = 2539,

        [EnumMember]
        DKK = 2540,

        [EnumMember]
        GBP = 2541,

        [EnumMember]
        HUF = 2542,

        [EnumMember]
        JPY = 2543,

        [EnumMember]
        NOK = 2544,

        [EnumMember]
        SEK = 2545,

        [EnumMember]
        SGD = 2546,

        [EnumMember]
        TRY = 2547,

        [EnumMember]
        USD = 2548,

        [EnumMember]
        ZAR = 2549,

        [EnumMember]
        HKD = 2550,

        [EnumMember]
        PLN = 2551,

        [EnumMember]
        NZD = 2552,

        [EnumMember]
        PHP = 2553,

        [EnumMember]
        BRL = 2554,

        [EnumMember]
        CZK = 2555,

        [EnumMember]
        CNH = 2651,

        [EnumMember]
        TWD = 4462,

        [EnumMember]
        INR = 4466,

        [EnumMember]
        IDR = 4476,

        [EnumMember]
        PEN = 4537,

        [EnumMember]
        KRW = 4581,

        [EnumMember]
        ILS = 5260,

        [EnumMember]
        HRK = 5349,

        [EnumMember]
        ISK = 5758,

        [EnumMember]
        THB = 6094,

        [EnumMember]
        MYR = 6635,

        [EnumMember]
        PKR = 6666,

        [EnumMember]
        RUB = 8418,

        [EnumMember]
        NGN = 11317,

        [EnumMember]
        MAD = 15054,

        [EnumMember]
        ARS = 15058,

        [EnumMember]
        MXN = 15059,

        [EnumMember]
        SAR = 20796,

        [EnumMember]
        KYD = 20805,

        [EnumMember]
        DEM = 23374,

        [EnumMember]
        FIM = 32959,

        [EnumMember]
        KZT = 36822

    }
}
