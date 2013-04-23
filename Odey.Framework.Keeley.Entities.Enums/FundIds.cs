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
        DYSSGBPISHARECLASS = 5747,
        [EnumMember]
        DYSSGBPMSHARECLASS = 5749,
        [EnumMember]
        DYSSGBPRSHARECLASS = 5750,
        [EnumMember]
        DYSSEURSHARECLASS = 5901,
        
        [EnumMember]
        MR11 = 5590,
        [EnumMember]
        MR11GBPSHARECLASS = 5746,
        [EnumMember]
        MR11USDSHARECLASS = 5902,
        [EnumMember]
        MR11GBPMSHARECLASS = 5903,
        [EnumMember]
        MR11EURMSHARECLASS = 5904,
        
        
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
        ALEGGBPASHARECLASS = 5517,
        [EnumMember]
        ALEGGBPDSHARECLASS = 5518,
        [EnumMember]
        ALEGUSDSHARECLASS = 5520,
        
        [EnumMember]
        OEAF = 5326,
        [EnumMember]
        OEAFEURASHARECLASS = 5523,
        [EnumMember]
        OEAFEURAISHARECLASS = 5524,
        [EnumMember]
        OEAFGBPDSHARECLASS = 5525,
        [EnumMember]
        OEAFGBPSHARECLASS = 5526,
        [EnumMember]
        OEAFEURISHARECLASS = 5528,
        [EnumMember]
        OEAFGBPISHARECLASS = 5529,
        [EnumMember]
        OEAFUSDSHARECLASS = 5530,
        
        
        [EnumMember]
        OF = 5592,
        [EnumMember]
        OFCHFASHARECLASS = 5910,
        [EnumMember]
        OFCHFBSHARECLASS = 5911,
        [EnumMember]
        OFEURBSHARECLASS = 5914,
        [EnumMember]
        OFGBPASHARECLASS = 5906,
        [EnumMember]
        OFGBPBSHARECLASS = 5907,
        [EnumMember]
        OFNOKASHARECLASS = 5912,
        [EnumMember]
        OFNOKBSHARECLASS = 5913,
        [EnumMember]
        OFUSDASHARECLASS = 5908,
        [EnumMember]
        OFUSDBSHARECLASS = 5909,
        
        
        [EnumMember]
        OPE = 5327,
        [EnumMember]
        OPEFGBPDSHARECLASS = 5531,        
        
        [EnumMember]
        ATLAS = 6053,
        [EnumMember]
        ATLAS_GBP_I_INC = 6054,
        [EnumMember]
        ATLAS_GBP_R_ACC = 6055,
        [EnumMember]
        ATLAS_GBP_R_INC = 6056,
        
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
        
    }
}
