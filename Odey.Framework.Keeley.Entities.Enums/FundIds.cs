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
        OEIMAC_USD_M = 7650,


        [EnumMember]
        GIANO94 = 4849,
        [EnumMember]
        GIANO94_GBP_R = 6807,

        [EnumMember]
        OUAR = 3609,
        [EnumMember]
        OUAR_GBP_R = 5511,
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
        OCE_GBP_M = 7412,
        [EnumMember]
        OCE_GBP_P_I = 7549,
        [EnumMember]
        OCE_GBP_P_R = 7548,


        [EnumMember]
        PORT = 5330,
        [EnumMember]
        PORT_GBP_I_ACC = 5532,
        [EnumMember]
        PORT_GBP_R_ACC = 5533,
        [EnumMember]
        PORT_GBP_R_INC = 5534,
        [EnumMember]
        PORT_GBP_M = 7413,
        [EnumMember]
        PORT_GBP_P_I_ACC = 6720,
        [EnumMember]
        PORT_GBP_P_R_ACC = 6721,

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
        ALEG_OLD = 4930,
        [EnumMember]
        ALEG_OLDEURISHARECLASS = 5515,
        [EnumMember]
        ALEG_OLDGBPSHARECLASS = 5516,
        [EnumMember]
        ALEG_OLD_GBP_AD = 5517,
        [EnumMember]
        ALEG_OLDGBPDSHARECLASS = 5518,
        [EnumMember]
        ALEG_OLDUSDSHARECLASS = 5520,
        [EnumMember]
        ALEG_OLDAUDSHARECLASS = 6354,


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
        OF_OLD = 5592,
        [EnumMember]
        OF_OLD_CHF_I = 5910,
        [EnumMember]
        OF_OLD_CHF_IP = 7573,
        [EnumMember]
        OF_OLD_CHF_R = 5911,
        [EnumMember]
        OF_OLD_CHF_RP = 8920,
        [EnumMember]
        OF_OLD_EUR_IP = 6839,
        [EnumMember]
        OF_OLD_EUR_R = 5914,
        [EnumMember]
        OF_OLD_EUR_RP = 7356,
        [EnumMember]
        OF_OLD_GBP_F = 8893,
        [EnumMember]
        OF_OLD_GBP_IH = 8921,
        [EnumMember]
        OF_OLD_GBP_IR = 5906,
        [EnumMember]
        OF_OLD_GBP_MW = 6732,
        [EnumMember]
        OF_OLD_GBP_R = 5907,
        [EnumMember]
        OF_OLD_GBP_RP = 7011,
        [EnumMember]
        OF_OLD_GBP_SIP = 7574,
        [EnumMember]
        OF_OLD_GBP_WM = 7010,

        [EnumMember]
        OF_OLD_NOK_I = 5912,
        [EnumMember]
        OF_OLD_NOK_R = 5913,
        [EnumMember]
        OF_OLD_USD_I = 5908,
        [EnumMember]
        OF_OLD_USD_IP = 7575,
        [EnumMember]
        OF_OLD_USD_R = 5909,
        [EnumMember]
        OF_OLD_USD_RP = 6986,

        [EnumMember]
        OOF = 10973,
        [EnumMember]
        OOF_CHF_I = 10982,
        [EnumMember]
        OOF_CHF_R = 10984,
        [EnumMember]
        OOF_EUR_I = 10986,
        [EnumMember]
        OOF_EUR_R = 10978,
        [EnumMember]
        OOF_EUR_RP = 10976,
        [EnumMember]
        OOF_GBP_F = 10974,
        [EnumMember]
        OOF_GBP_IP = 10985,
        [EnumMember]
        OOF_GBP_R = 10975,
        [EnumMember]
        OOF_GBP_RP = 10979,
        [EnumMember]
        OOF_NOK_R = 10977,
        [EnumMember]
        OOF_USD_I = 10981,
        [EnumMember]
        OOF_USD_R = 10980,
        [EnumMember]
        OOF_USD_RP = 10983,

        [EnumMember]
        OPE = 5327,
        [EnumMember]
        OPE_GBP_R = 5531,
        [EnumMember]
        OPE_EUR_G = 5955,
        [EnumMember]
        OPE_GBP_IR = 6280,
        [EnumMember]
        OPE_EUR_I_OLD = 8812,
        [EnumMember]
        OPE_EUR_I=	10988,
        [EnumMember]
        OPE_USD_I=10989,
        [EnumMember]
        OPE_GBP_I=	10990,

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
        ATLAS_GBP_M = 6897,
        [EnumMember]
        ATLAS_GBP_R = 7033,

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
        SWAN_NOK_I = 7510,
        [EnumMember]
        SWAN_USD_M = 7803,
        [EnumMember]
        SWAN_EUR_G = 8007,

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
        DEVM_EUR_M = 8919,
        [EnumMember]
        DEVM_EUR_R = 9779,
        [EnumMember]
        DEVM_EUR_LI = 10858,
        [EnumMember]
        DEVM_GBP_LI = 10859,
        [EnumMember]
        DEVM_USD_LI = 10860,
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
        CAMO_USD = 7383,

        [EnumMember]
        WSEG = 6823,

        [EnumMember]
        ITR = 6825,
        [EnumMember]
        ITR_GBP_MW = 6829,
        [EnumMember]
        ITR_USD_MW = 6827,

        [EnumMember]
        KELT = 6970,
        [EnumMember]
        KELT_GBP_A = 6973,
        [EnumMember]
        KELT_EUR_B = 6974,
        [EnumMember]
        KELT_EUR_A_Acc = 6978,
        [EnumMember]
        KELT_EUR_I = 7299,
        [EnumMember]
        KELT_GBP_I = 7302,
        [EnumMember]
        KELT_GBP_M = 7303,
        [EnumMember]
        KELT_USD_I = 7314,
        [EnumMember]
        KELT_GBP_R = 7497,
        [EnumMember]
        KELT_EUR_R = 7381,
        [EnumMember]
        KELT_USD_R = 9778,


        [EnumMember]
        MW = 6994,
        [EnumMember]
        DAMI = 6995,

        [EnumMember]
        FDXC = 7492,

        [EnumMember]
        FDXH = 7493,

        [EnumMember]
        DEFF = 7505,

        [EnumMember]
        ARFF = 7504,//GBP I
        [EnumMember]


        ARFF_EUR_I_IRL = 7620,
        [EnumMember]
        ARFF_GBP_M_IRL = 7555,
        [EnumMember]
        ARFF_GBP_CONST = 7704,
        [EnumMember]
        ARFF_GBP_A_IRL = 7553,
        [EnumMember]
        ARFF_USD_I_IRL = 7625,
        [EnumMember]
        ARFF_USD_A_IRL = 7743,
        [EnumMember]
        ARFF_USD_C0616_IRL = 7792,
        [EnumMember]
        ARFF_GBP_C1016_IRL = 7921,
        [EnumMember]
        ARFF_USD_C1016_IRL = 7976,
        [EnumMember]
        ARFF_GBP_C1116_IRL = 7993,
        [EnumMember]
        ARFF_GBP_C0217_IRL = 7999,
        [EnumMember]
        ARFF_GBP_C1117_IRL = 8986,
        [EnumMember]
        ARFF_GBP_C1217_IRL = 8993,
        [EnumMember]
        ARFF_GBP_C0118_IRL = 9027,
        [EnumMember]
        ARFF_USD_C0818_IRL = 9793,
        [EnumMember]
        ARFF_GBP_C1018_IRL = 9823,
        [EnumMember]
        ARFF_USD_C0620_IRL = 10353,
        [EnumMember]
        ARFF_GBP_C1220_IRL = 10517,

        [EnumMember]
        RAFO = 7577,
        [EnumMember]
        RAFO_GBP_M = 7594,
        [EnumMember]
        RAFO_GBP_I = 7644,

        [EnumMember]
        BVFF = 7894,
        [EnumMember]
        BVFF_EUR = 7901,
        [EnumMember]
        RAFO_USD_M = 8809,
        [EnumMember]
        BNUA = 8906,
        [EnumMember]
        LEGE = 8987,

        [EnumMember]
        IAR = 9838,
        [EnumMember]
        IAR_GBP_M = 9854,
        [EnumMember]
        IAR_GBP_R = 9855,
        [EnumMember]
        IAR_EUR_I = 9856,
        [EnumMember]
        IAR_EUR_R = 9857,
        [EnumMember]
        IAR_USD_I = 9858,
        [EnumMember]
        IAR_USD_R = 9859,
        [EnumMember]
        NAT = 9903,
        [EnumMember]
        NAT_EUR_I = 9904,
        [EnumMember]
        NAT_GBP_I = 9905,
        [EnumMember]
        NAT_GBP_M = 9906,
        [EnumMember]
        NAT_USD_M = 9908,
        [EnumMember]
        NAT_USD_D = 10171,
        [EnumMember]
        IPB = 9963,

        [EnumMember]
        SSF = 10056,
        [EnumMember]
        SSF_GBP_M = 10057,
        [EnumMember]
        SSF_GBP_I = 10133,
        [EnumMember]
        SSF_EUR_I = 10359,
        [EnumMember]
        SSF_EUR_R = 10360,
        [EnumMember]
        SSF_GBP_R = 10363,
        [EnumMember]
        SSF_USD_R = 10388,
        [EnumMember]
        SSF_CHF_R = 10392,
        [EnumMember]
        SSF_CHF_I = 10393,

        [EnumMember]
        ODIF = 10439,
        [EnumMember]
        ODIF_USD_M = 10440,
        [EnumMember]
        ODIF_EUR_I = 10441,
        [EnumMember]
        ODIF_GBP_I = 10442,
        [EnumMember]
        ODIF_GBP_M = 10443,
        [EnumMember]
        ODIF_CHF_I = 10444,

        [EnumMember]
        GILT = 10454,
        [EnumMember]
        GEM = 10700,
        [EnumMember]
        GEM_CHF_I = 10713,
        [EnumMember]
        GEM_CHF_LI = 10729,
        [EnumMember]
        GEM_CHF_R = 10714,
        [EnumMember]
        GEM_CHF_S = 10725,
        [EnumMember]
        GEM_EUR_I = 10707,
        [EnumMember]
        GEM_EUR_LI = 10728,
        [EnumMember]
        GEM_EUR_R = 10709,
        [EnumMember]
        GEM_EUR_S = 10723,
        [EnumMember]
        GEM_GBP_I = 10703,
        [EnumMember]
        GEM_GBP_LI = 10727,
        [EnumMember]
        GEM_GBP_R = 10704,
        [EnumMember]
        GEM_GBP_S = 10724,
        [EnumMember]
        GEM_USD_LI = 10726,
        [EnumMember]
        GEM_USD_R = 10702,
        [EnumMember]
        GEM_USD_S = 10701,
        [EnumMember]
        GEMF = 10817,
        [EnumMember]
        GEMF_USD_LI = 10820,
        [EnumMember]
        GEMF_USD_S = 10821,
        [EnumMember]
        GEMF_NOK_S_IRL=	10868,
        [EnumMember]
        GEMF_USD_I_IRL=	10870,
        [EnumMember]
        GEMF_USD_LI_IRL =10871
    }
}
