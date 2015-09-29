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
    }
}
