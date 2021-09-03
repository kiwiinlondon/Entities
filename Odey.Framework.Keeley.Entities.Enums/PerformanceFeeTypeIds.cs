using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
     [DataContract]
    public enum PerformanceFeeTypeIds
    {
        [EnumMember]
        Absolute=1,
        [EnumMember]
        Relative=2
    }
}
