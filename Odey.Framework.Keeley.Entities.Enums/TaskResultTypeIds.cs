using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum TaskResultTypeIds
    {
        [EnumMember]
        Information	=1,
        [EnumMember]
        Warning	=2,
        [EnumMember]
        Exception	=3
    }
}
