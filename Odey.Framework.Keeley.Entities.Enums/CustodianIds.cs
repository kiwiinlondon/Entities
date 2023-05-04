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
        BOAM = 9799,
        [EnumMember]
        RBC = 4356,
        [EnumMember]
        JPFI = 10813,
        [EnumMember]
        JPMS = 11447,
        [EnumMember]
        CITI = 3705,
        [EnumMember]
        USBank = 10818,
        [EnumMember]
        JPMREPO = 11462,
        [EnumMember]
        JPMPB = 11463,
        [EnumMember]
        JPMOTC = 11464,
        [EnumMember]
        BAMLOTC = 11465,
        [EnumMember]
        GSFX = 7557,
        [EnumMember]
        BNYFX = 7957,
        [EnumMember]
        MSFO = 9920,
        [EnumMember]
        MSPB = 11468,
        [EnumMember]
        GSPB = 11469,

    }
}
