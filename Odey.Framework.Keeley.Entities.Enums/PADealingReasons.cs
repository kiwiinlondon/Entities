using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]

    public enum PADealingReasons
    {
        [Description("Restricted List")]
        [EnumMember]
        RestrictedList = 1,

        
    }
}
