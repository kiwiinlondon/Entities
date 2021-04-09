using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum InvestmentManagerIds
    {
        [EnumMember]
        OdeyAssetManagement	= 1,
        [EnumMember]
        BrookAssetManagement =2,
        [EnumMember]
        OdeyWealthManagement =3
    }
}
