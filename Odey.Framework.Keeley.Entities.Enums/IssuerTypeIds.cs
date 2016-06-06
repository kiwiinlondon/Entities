using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum IssuerTypeIds
    {
        
        [EnumMember]
        Default = 1,
        
        [EnumMember]
        CurrencyPair=2,
      
      
    }
}

