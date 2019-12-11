using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum CustodianIds
    {
        [EnumMember]
        Unknown = 3762,        
        [EnumMember]
        UBSL = 4222,
        [EnumMember]
        MSDW = 3643,
        [EnumMember]
        JPML = 3657,
        [EnumMember]
        BONY = 4768,
        [EnumMember]
        GSIL = 4206,
        [EnumMember]
        BOAM = 9799
    }
}
