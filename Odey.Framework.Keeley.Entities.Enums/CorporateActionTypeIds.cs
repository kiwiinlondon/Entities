using System.ComponentModel;
using System.Runtime.Serialization;


namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]

    public enum CorporateActionTypeIds
    {
        [Description("Stock Split")]
        [EnumMember]
        StockSplit = 1,
        [Description("Sedol Change")]
        [EnumMember]
        SedolChange = 2,
        [Description("Isin Change")]
        [EnumMember]
        IsinChange = 3,
        [Description("Name Change")]
        [EnumMember]
        NameChange = 4,
        [Description("Share Holder Meeting")]
        [EnumMember]
        ShareHolderMeeting = 5,
        [Description("Cash Dividend")]
        [EnumMember]
        CashDividend = 6,
        [Description("Stock Dividend")]
        [EnumMember]
        StockDividend = 7,
        [Description("Ticker Chang")]
        [EnumMember]
        TickerChange = 8,
        [Description("Rights Offer")]
        [EnumMember]
        RightsOffer = 9,
        [Description("Cusip Change")]
        [EnumMember]
        CusipChange = 10
    }
}
