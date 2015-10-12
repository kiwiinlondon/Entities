namespace Odey.Framework.Keeley.Entities
{
    public partial class PADealingBalance
    {
        public override string ToString()
        {
            return $"PADealingBalanceID:{PADealingBalanceID} - UserId:{UserID} - InstrumentMarketId:{InstrumentMarketID} - UserAccountId:{UserAccountID} - Quantity:{Quantity} - BookCost:{BookCost} - RealisedPNL:{RealisedPNL}";
        }
    }
}