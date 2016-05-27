using System;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    public partial class Fund
    {        
        public Fund(LegalEntity legalEntity)
            : this()
        {
            LegalEntity = legalEntity;
        }        

        public int? CountryID
        {
            get
            {
                return LegalEntity.CountryID;
            }
        }

        public string Name
        {
            get
            {
                return LegalEntity.Name;
            }
        }

        public string LongName
        {
            get
            {
                return LegalEntity.LongName;
            }
        }

        public int? FMOrgId
        {
            get
            {
                return LegalEntity.FMOrgId;
            }
        }

        public PeriodicityIds DealingFrequencyId
        {
            get
            {
                return (PeriodicityIds)DealingDateDefinition.PeriodicityId;
            }
        }
    }
}

