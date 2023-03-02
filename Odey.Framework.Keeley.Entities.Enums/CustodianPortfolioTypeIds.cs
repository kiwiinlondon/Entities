using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum CustodianPortfolioTypeIds
    {
        [EnumMember]
        TradeDateBalance	=1,

        [EnumMember]
        RealisedPNL	= 2,
    }
}
