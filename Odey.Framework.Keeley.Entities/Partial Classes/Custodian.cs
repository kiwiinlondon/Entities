using System;

namespace Odey.Framework.Keeley.Entities
{
    partial class Custodian
    {

        public Custodian()
        {
        }

        public Custodian(LegalEntity legalEntity)
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

        public int? FMOrgID
        {
            get
            {
                return LegalEntity.FMOrgId;
            }
        }

        public int? BBCompany
        {
            get
            {
                return LegalEntity.BBCompany;
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
    }
}