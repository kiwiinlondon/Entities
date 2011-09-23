
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
 [DataContract]
    public enum AnalyticTypeIds
    {
        [EnumMember]
        None=0,
        [EnumMember]
        BBVolumeAverage30D=1
    }
}

