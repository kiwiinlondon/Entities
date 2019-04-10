using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FileExtensionIds
    {
        [EnumMember]
        PDF = 1,
        [EnumMember]
        PPTX = 2,
        [EnumMember]
        PNG = 3,
        [EnumMember]
        JPG = 4,
        [EnumMember]
        XLSX = 5,
        [EnumMember]
        TXT = 6,
        [EnumMember]
        DOCX = 7,
        [EnumMember]
        HTML = 8,
        [EnumMember]
        GIF = 9,
        [EnumMember]
        DOC = 10,
        [EnumMember]
        XLSM = 11,
        [EnumMember]
        XLSB = 12,
        [EnumMember]
        XLS = 13,
        [EnumMember]
        MSG = 14,
        [EnumMember]
        PPTM = 15,
        [EnumMember]
        ZIP = 17
    }
}
