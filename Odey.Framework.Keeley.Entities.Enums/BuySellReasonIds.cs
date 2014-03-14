using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum BuySellReasonIds
    {
        [EnumMember]
        Buy = 1,
        [EnumMember]
        Sell = 2,
        [EnumMember]
        BuyCover = 3,
        [EnumMember]
        SellToOpen = 4,
        [EnumMember]
        BuyToClose = 5,
        [EnumMember]
        SellShort = 6,
        [EnumMember]
        BuyToOpen = 7,
        [EnumMember]
        SellToClose = 8,
        [EnumMember]
        Redemption = 9,
        [EnumMember]
        Subscription = 10,
        [EnumMember]
        SubscriptionSwitch = 11
    }
}
