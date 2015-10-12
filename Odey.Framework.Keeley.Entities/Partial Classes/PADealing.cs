namespace Odey.Framework.Keeley.Entities
{
    public partial class PADealing
    {
        public override string ToString()
        {
            return $"PADealingID:{PADealingID} - RequestUserId:{RequestUserID} - InstrumentMarketId:{InstrumentMarketID} - AccountId:{PADealingAccountID} - RequestQuantity:{RequestQuantity} - RequestValue:{RequestValue}" +
                   $"IsExistingHolding:{IsExistingHolding} - ActualQuantity:{ActualQuantity} - ActualValue:{ActualValue} - Cost:{Cost}" +
                   $"IsComplianceApproved:{IsComplianceApproved} - ComplianceUserID:{ComplianceUserID} - IsTraderApproved:{IsTraderApproved} - TraderUserID:{TraderUserID}";
        }
    }
}