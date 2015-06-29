using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum IndexIds
    {    
        
        [EnumMember]
        HFRX_Macro_Multi_Strategy = 20442,
        
        [EnumMember]
        BAIF = 11668,
        
        [EnumMember]
        FT_WLD_EUROPE_TRI_EUR = 22666,
        
        [EnumMember]
        FTSE_WMA_Balanced = 9922,
        
        [EnumMember]
        MSCI_Daily_TR_Gross_Europe = 9918,
        
        [EnumMember]
        MSCI_Daily_TR_Gross_World_USD = 18763,
        
        [EnumMember]
        MSCI_Daily_TR_Net_Europe = 9916,
        
        [EnumMember]
        MSCI_Daily_TR_Net_Europe_Ex_UK = 9917,
        
        [EnumMember]
        MSCI_World_Net_TR_World = 9920,
        
        [EnumMember]
        MSCI_Europe_Index = 9915,

        [EnumMember]
        MSCI_World_Index = 9919,

    }
}
