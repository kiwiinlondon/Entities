using System;

namespace Odey.Framework.Keeley.Entities
{
    partial class Market
    {

        public Market()
        {
        }

        public Market(LegalEntity legalEntity)
            : this()
        {
            LegalEntity = legalEntity;
        }

        public int CountryID
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

        public int? FMOrgID
        {
            get
            {
                return LegalEntity.FMOrgId;
            }
        }

        public string LongName
        {
            get
            {
                return LegalEntity.LongName;
            }
        }
    }
}

