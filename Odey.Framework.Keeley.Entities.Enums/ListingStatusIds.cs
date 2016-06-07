using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ListingStatusIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Active = 1,
        [EnumMember]
        Suspended = 2,
        [EnumMember]
        Acquired = 3,
        [EnumMember]
        PrivatePlacement = 4,
        [EnumMember]
        Delisted = 5,
        [EnumMember]
        Expired = 6,
        [EnumMember]
        OdeyUnlistedFund = 7,
        [EnumMember]
        OdeyManagementShareClass = 8
    }
}
