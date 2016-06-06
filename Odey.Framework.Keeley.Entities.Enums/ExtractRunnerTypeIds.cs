using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ExtractRunnerTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        AllFunds = 1,
        [EnumMember]
        Standard = 2
    }
}