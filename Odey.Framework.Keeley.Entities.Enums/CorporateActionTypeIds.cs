using System.ComponentModel;
using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum CorporateActionTypeIds
    {
        [Description("Stock Split")]
        [EnumMember]
        StockSplit = 1,
    }
}
