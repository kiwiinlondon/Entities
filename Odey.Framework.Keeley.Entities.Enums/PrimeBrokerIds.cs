using System.ComponentModel;

namespace Odey.Framework.Keeley.Entities.Enums
{
    /// <summary>
    /// LegalEntityIDs of all Prime Brokers (used in Fund Cost Analysis report)
    /// 
    /// SELECT * FROM LegalEntity WHERE LegalEntityID IN (4244, 4281, 4397, 4285)
    /// </summary>
    public enum PrimeBrokerIds
    {
        [Description("Goldman Sachs")]
        GS = 4244,

        [Description("JPMorgan Chase")]
        JPM = 4281,

        [Description("UBS")]
        UBS = 4285,

        [Description("Morgan Stanley")]
        MS = 4397,
    }
}
