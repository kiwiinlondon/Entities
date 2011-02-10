using System;

namespace Odey.Framework.Keeley.Entities
{
    partial class Fund
    {

        public Fund()
        {
        }

        public Fund(LegalEntity legalEntity)
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
    }
}

