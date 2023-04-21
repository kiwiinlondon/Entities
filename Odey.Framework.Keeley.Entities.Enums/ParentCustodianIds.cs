using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ParentCustodianIds
    {
        [EnumMember]
        BankOfAmerica = 4492,
        [EnumMember]
        BankOfNewYork = 4703,
        [EnumMember]
        GoldmanSachs = 4244,
        [EnumMember]
        JPMorgan = 4281,
        [EnumMember]
        MorganStanley = 4397
    }


}
