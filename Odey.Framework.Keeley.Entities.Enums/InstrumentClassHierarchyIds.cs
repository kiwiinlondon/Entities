using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum  InstrumentClassHierarchyIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        FundManager = 1,
        [EnumMember]
        Odey = 2
    }
}


