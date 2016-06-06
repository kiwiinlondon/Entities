using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ChargeTypeIds
    {
        [EnumMember]
        Commission=2,
        [EnumMember]
        Fees=3,
        [EnumMember]
        StampDuty=4,
        [EnumMember]
        Miscellaneous=5,
        [EnumMember]
        PTMLevy=6,
        [EnumMember]
        SECFees=7,
        [EnumMember]
        AccruedInt=8,
        [EnumMember]
        AccruedIntDirty=9,
        [EnumMember]
        IssuingFirmCharge=10,
        [EnumMember]
        CFDCommission=11,
        [EnumMember]
        ClearingFees=12,
        [EnumMember]
        ExchangeFees=13
    }
}
