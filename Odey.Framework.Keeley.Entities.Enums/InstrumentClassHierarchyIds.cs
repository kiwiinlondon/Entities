using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
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


