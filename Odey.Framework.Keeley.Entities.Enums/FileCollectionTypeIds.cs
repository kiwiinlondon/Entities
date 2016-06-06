using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum FileCollectionTypeIds
    {
        [EnumMember]
        SFTP = 1,
        [EnumMember]
        FTP = 2,
        [EnumMember]
        Directory = 3
    }
}
