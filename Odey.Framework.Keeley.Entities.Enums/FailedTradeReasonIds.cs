using System.Runtime.Serialization;

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
