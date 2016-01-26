namespace Odey.Framework.Keeley.Entities
{
    partial class Administrator
    {
        public Administrator(LegalEntity legalEntity)
            : this()
        {
            LegalEntity = legalEntity;
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