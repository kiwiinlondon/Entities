using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    public enum FailedTradeReasonIds
    {
        [EnumMember]
        CounterpartyShortOfShares=1,
        [EnumMember]
        PBLateBorrowing=2,
        [EnumMember]
        IncorrectInstructionsCounterparty=3,
        [EnumMember]
        IncorrectInstructionsCustodian=4,
        [EnumMember]
        DidNotFail=5,
        [EnumMember]
        FundShortOfShares=6
    }
}
