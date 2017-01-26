﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{

    [Flags]
    [DataContract]
    public enum UserTypeIds
    {
        [EnumMember]        
        None = 0,
        [EnumMember]
        FundManagement = 1 << 0,
        [EnumMember]
        Research = 1 << 1,
        [EnumMember]
        IT = 1 << 2,
        [EnumMember]
        SAV = 1 << 3,
        [EnumMember]
        Admin = 1 << 4,
        [EnumMember]
        ClientServices = 1 << 5,
        [EnumMember]
        Marketing = 1 << 6,
        [EnumMember]
        Compliance = 1 << 7,
        [EnumMember]
        Wealth = 1 << 8,
        [EnumMember]
        Trading = 1 << 9,
        [EnumMember]
        Accounts = 1 << 10
    }
}
