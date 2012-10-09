using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ExtractDeliveryTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Email = 1,
        [EnumMember]
        Sftp = 3,
        [EnumMember]
        SftpAndEmail = 4,
        [EnumMember]
        FTP = 5,
        [EnumMember]
        FTPWithResponse = 6,
        [EnumMember]
        SaveToDirectory = 7
    }
}