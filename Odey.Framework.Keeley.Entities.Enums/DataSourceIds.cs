using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum DataSourceIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Arkus = 1,
        [EnumMember]
        Bloomberg = 2,
    }
}