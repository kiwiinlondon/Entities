using System.ComponentModel;
using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum AccountTypeIds
    {
        [Description("Margin")]
        [EnumMember]
        Margin = 1,

        [Description("Custody")]
        [EnumMember]
        Custody = 2,

        [Description("Swap")]
        [EnumMember]
        Swap = 3,

        [Description("Futures & Options")]
        [EnumMember]
        FuturesAndOptions = 4,

    }
}
