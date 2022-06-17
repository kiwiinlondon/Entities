using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum PerformanceFeeMethodologyIds
    {
        [EnumMember]
        Equalisation = 1,
        [EnumMember]
        ReferenceAsset	= 2,
        [EnumMember]
        WeightedAverage	= 3,
        [EnumMember]
        ShareSeries = 4
    }
}
