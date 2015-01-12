using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum FundIds
    {
        [EnumMember]
        OEI = 741,
        [EnumMember]
        OEIGBPASHARECLASS = 5505,
        [EnumMember]
        OEIGBPBSHARECLASS = 5507,
        [EnumMember]
        OEIUSDSHARECLASS = 5508,
        [EnumMember]
        OEIEURSHARECLASSMAC = 5584,
        [EnumMember]
        OEIGBPAMANSHARECLASS = 5766,       
        [EnumMember]
        OEIEURMSHARECLASS = 6051,
        [EnumMember]
        OEIMAC = 4927,
        [EnumMember]
        OEIMACGBPASHARECLASS = 5512,
        [EnumMember]
        OEIMACGBPBSHARECLASS = 5513,
        [EnumMember]
        OEIMACGBPBMSHARECLASS = 5905,        
        
        [EnumMember]
        GIANO94 = 4849,
        [EnumMember]
        GIANO94_GBP_R = 6807,
        
        [EnumMember]
        OUAR = 3609,
        [EnumMember]
        OUAR_GBP_I = 5511,
        [EnumMember]
        OUAR_EUR = 5915,
        [EnumMember]
        OUAR_GBP_M = 5510,
        [EnumMember]
        OUAR_USD = 6031,
        
        [EnumMember]
        DYSS = 5591,
        [EnumMember]
        DYSS_GBP_I = 5747,
        [EnumMember]
        DYSS_GBP_M = 5749,
        [EnumMember]
        DYSS_GBP_R = 5750,
        [EnumMember]
        DYSS_EUR_I = 5901,
        [EnumMember]
        DYSS_USD_R = 6239,
        [EnumMember]
        DYSS_EUR_R = 6244,
        
        
        [EnumMember]
        MR11 = 5590,
        [EnumMember]
        MR11_GBP_R = 5746,
        [EnumMember]
        MR11_USD_R = 5902,
        [EnumMember]
        MR11_GBP_M = 5903,
        [EnumMember]
        MR11_EUR_M = 5904,
        [EnumMember]
        MR11_GBP_MW = 6580,
        [EnumMember]
        MR11_EUR_MW = 6881,

        [EnumMember]
        OPUS = 5328,
        [EnumMember]
        OPUS_GBP_A_ACC = 6162,
        [EnumMember]
        OPUS_GBP_I_ACC = 5953,
        [EnumMember]
        OPUS_GBP_I_INC = 5954,

        [EnumMember]
        OCE = 5082,
        [EnumMember]
        OCE_GBP_I_ACC = 5522,
        [EnumMember]
        OCE_GBP_I_INC = 5521,
        
        [EnumMember]
        PORT = 5330,
        [EnumMember]
        PORT_GBP_I_ACC = 5532,
        [EnumMember]
        PORT_GBP_R_ACC = 5533,
        [EnumMember]
        PORT_GBP_R_INC = 5534,
        
        [EnumMember]
        VITR = 5333,
       
        [EnumMember]
        FEBT = 5084,
        
        [EnumMember]
        FEBX = 5313,
        
        [EnumMember]
        FGT = 5314,
        
        [EnumMember]
        GARD = 5315,
        
        [EnumMember]
        BARC = 4963,
        
        [EnumMember]
        BARF = 4964,
        
        [EnumMember]
        TPTL = 5332,
        
        [EnumMember]
        BEST = 4965,
        
        [EnumMember]
        OBID = 5325,
        
        [EnumMember]
        CFNO = 4966,
        
        [EnumMember]
        MMAG = 5987,
        
        [EnumMember]
        OSYN = 5329,
        
        [EnumMember]
        CAC = 2485,
        
        [EnumMember]
        JLEG = 5732,
        
        [EnumMember]
        ALEG = 4930,
        [EnumMember]
        ALEGEURISHARECLASS = 5515,
        [EnumMember]
        ALEGGBPSHARECLASS = 5516,
        [EnumMember]
        ALEG_GBP_AD = 5517,
        [EnumMember]
        ALEGGBPDSHARECLASS = 5518,
        [EnumMember]
        ALEGUSDSHARECLASS = 5520,
        [EnumMember]
        ALEGAUDSHARECLASS = 6354,

        
        [EnumMember]
        OEAF = 5326,
        [EnumMember]
        OEAF_EUR_A = 5523,
        [EnumMember]
        OEAF_EUR_AI = 5524,
        [EnumMember]
        OEAF_GBP_D = 5525,
        [EnumMember]
        OEAF_GBP_O = 5526,
        [EnumMember]
        OEAF_EUR_I = 5528,
        [EnumMember]
        OEAF_GBP_I = 5529,
        [EnumMember]
        OEAF_USD_O = 5530,
        [EnumMember]
        OEAF_USD_BI = 6525,
        [EnumMember]
        OEAF_EUR_CI = 6707,

        
        [EnumMember]
        OF = 5592,
        [EnumMember]
        OF_CHF_A = 5910,
        [EnumMember]
        OF_CHF_R = 5911,
        [EnumMember]
        OF_EUR_R = 5914,
        [EnumMember]
        OF_GBP_I = 5906,
        [EnumMember]
        OF_GBP_B = 5907,
        [EnumMember]
        OF_NOK_A = 5912,
        [EnumMember]
        OF_NOK_R = 5913,
        [EnumMember]
        OF_USD_A = 5908,
        [EnumMember]
        OF_USD_R = 5909,
        
        
        [EnumMember]
        OPE = 5327,
        [EnumMember]
        OPE_GBP_R = 5531,
        [EnumMember]
        OPE_EUR_R = 5955,  
        
        [EnumMember]
        ATLAS = 6053,//I S
        [EnumMember]
        ATLAS_GBP_R_S = 6055,
        [EnumMember]
        ATLAS_GBP_I = 6654,
        [EnumMember]
        ATLAS_USD_I = 6824,
        [EnumMember]
        ATLAS_EUR_I = 6837,
        
        [EnumMember]
        ORION = 6121,
        [EnumMember]
        ORION_EUR_M = 6123,
        [EnumMember]
        ORION_GBP_I = 6125,
        [EnumMember]
        ORION_GBP_M = 6126,
        [EnumMember]
        ORION_GBP_R = 6128,
        [EnumMember]
        ORION_USD_I = 6129,
        
        [EnumMember]
        NAVER = 6130,
        [EnumMember]
        NAVER_EUR_M = 6131,
        [EnumMember]
        NAVER_GBP_I = 6133,
        [EnumMember]
        NAVER_GBP_M = 6134,
        [EnumMember]
        NAVER_GBP_R = 6136,
        [EnumMember]
        NAVER_USD_I = 6137,
        [EnumMember]
        NAVER_EUR_R = 6821,

        
        
        [EnumMember]
        SWAN = 6184,
        [EnumMember]
        SWAN_EUR_M = 6190,
        [EnumMember]
        SWAN_EUR_R = 6187,
        [EnumMember]
        SWAN_GBP_I = 6185,
        [EnumMember]
        SWAN_GBP_M = 6191,
        [EnumMember]
        SWAN_GBP_R = 6188,
        [EnumMember]
        SWAN_USD_I = 6186,
        [EnumMember]
        SWAN_USD_R = 6189,
        [EnumMember]
        SWAN_USD_IR = 6243,
        [EnumMember]
        SWAN_EUR_IR = 6293,
        [EnumMember]
        SWAN_AUD_I = 6568,

        [EnumMember]
        DEVM = 6253,
        [EnumMember]
        DEVM_EUR_I = 6285,
        [EnumMember]
        DEVM_STI = 6263,
        [EnumMember]
        DEVM_STM = 6264,
        [EnumMember]
        DEVM_USD_R = 6313,
        [EnumMember]
        DEVM_STR = 6383,

        [EnumMember]
        EAR = 6437,
        [EnumMember]
        EAR_GBP_M = 6448,
        [EnumMember]
        EAR_GBP_S = 6449,
        [EnumMember]
        EAR_GBP_R = 6476,
        [EnumMember]
        EAR_EUR_S = 6451,
        [EnumMember]
        EAR_EUR_I = 6458,
         [EnumMember]
        EAR_EUR_M = 6520,
        [EnumMember]
        EAR_EUR_R = 6495,
        [EnumMember]
        EAR_USD_S = 6459,
        [EnumMember]
        EAR_USD_M = 6447,
        [EnumMember]
        EAR_USD_I = 6470,
        [EnumMember]
        EAR_USD_R = 6526,
        [EnumMember]
        EAR_GBP_MW = 6576,
        

        [EnumMember]
        OTR = 6552,
        [EnumMember]
        OTR_GBP_I = 6656,
        [EnumMember]
        OTR_GBP_R = 6657,
        [EnumMember]
        OTR_USD_R = 6590,
        [EnumMember]
        OTR_USD_I = 6658,
        [EnumMember]
        OTR_EUR = 6739,
        

        [EnumMember]
        CAMO = 6684,

        [EnumMember]
        WSEG = 6823,

        [EnumMember]
        ITR = 6825,
        [EnumMember]
        ITR_GBP_MW = 6829,
        [EnumMember]
        ITR_USD_MW = 6827,
        
    }
}
