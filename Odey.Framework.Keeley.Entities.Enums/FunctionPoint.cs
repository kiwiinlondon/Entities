using System.ComponentModel;
using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum FunctionPointIds
    {
        [EnumMember]
        [Description("Transfer Event")]
        TransferEvent = 1
    }
}
