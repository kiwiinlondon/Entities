using System.ComponentModel;
using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum PADealingBrokerIds
    {
        [Description("Odey Wealth Management (UK) Ltd")]
        [EnumMember]
        OdeyWealthManagementUK = 6783,

        [Description("INAPPLICABLE ORGANISATION")]
        [EnumMember]
        Other = 3762,
       
    }
}
