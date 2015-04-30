using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
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
