﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
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
