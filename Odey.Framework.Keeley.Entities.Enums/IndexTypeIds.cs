using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum IndexTypeIds
    {
        
        [EnumMember]
        Price = 1,
        
        [EnumMember]
        Gross=2,
        
        [EnumMember]
        Net=3,
        
        [EnumMember]
        Other=4,
        
        
    }
}

