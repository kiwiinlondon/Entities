
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
 [DataContract]
    public enum RiskAnalyticTypeIds
    {

        [EnumMember]
        TotalRisk = 1,
        
        [EnumMember]
        PercentSystematicTotalRisk = 2,

        [EnumMember]
        Sep2001September11th = 28,

        [EnumMember]
        IndexVaRPrimarySettings = 31,

        [EnumMember]
        IndexVaRSecondarySettings = 33,


    }
}

