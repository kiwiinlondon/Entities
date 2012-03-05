using System;
using System.Linq;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    partial class Issuer
    {

        public Issuer()
        {
        }

        public Issuer(int legalEntityId)
        {
            LegalEntityID = legalEntityId;
        }   

        public Issuer(LegalEntity legalEntity)
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

        private IssuerIndustry OdeyIssuerIndustry
        {
            get
            {
                return IssuerIndustries.Where(a => a.IndustryClassificationID == (int)IndustryClassificationIds.Odey).FirstOrDefault();
            }
        }

        public int OdeyIndustryId
        {
            get
            {
                return OdeyIssuerIndustry.IndustryID;
            }
            set
            {
                OdeyIssuerIndustry.IndustryID = value;
            }

        }
    }
}
