using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
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