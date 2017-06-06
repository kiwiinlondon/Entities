using System.ComponentModel;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]

    public enum ValuationMethodologyIds
    {
        [Description("Default")]
        [EnumMember]
        Default = 0,

        [Description("Cost")]
        [EnumMember]
        Cost = 1,

        [Description("Last Traded")]
        [EnumMember]
        LastTraded = 2,

        [Description("Valuation Committee")]
        [EnumMember]
        ValuationCommittee = 3,
    }
}