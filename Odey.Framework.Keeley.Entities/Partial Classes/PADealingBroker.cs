using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    public partial class PADealingBroker
    {
        public string Name
        {
            get
            {
                if (this.LegalEntityId == (int)PADealingBrokerIds.Other)
                    return "Other";

                return LegalEntity.Name;
            }
        }
    }
}