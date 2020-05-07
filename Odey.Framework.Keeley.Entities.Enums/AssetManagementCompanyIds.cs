using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum  AssetManagementCompanyIds
    {
        [EnumMember]
        OdeyAssetManagementLLP =	6398,
        [EnumMember]
        OdeyInvestmentFundsPLC	= 6771,
        [EnumMember]
        OdeyInvestmentsPLC = 6772,
        [EnumMember]
        LFOdeyInvestmentFunds = 6773,
        [EnumMember]
        LFOdeyFunds = 6774,
        [EnumMember]
        OdeyWealthManagementLtd = 6783,
        [EnumMember]
        OdeyIrishFeederICAV = 7561

    }
}
