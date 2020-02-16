using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum AttributionSourceIds
    {
        [Description("EoD")]
        [EnumMember]
        Master = 1,
        [EnumMember]
        Valuation = 2
    }
}
