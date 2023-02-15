using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum InvestmentGuidelineGroupIds
    {
        [EnumMember]
        InternalInvestmentGuidelines	= 1,
        [EnumMember]
        ProspectusLimits	=4,
        [EnumMember]
        UCITSRules	=3
    }
}
