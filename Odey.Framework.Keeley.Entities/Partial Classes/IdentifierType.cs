using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    partial class IdentifierType
    {
        public IdentifierTypeIds IdentifierTypeIDAsEnum
        {
            get
            {
                return (IdentifierTypeIds)IdentifierTypeID;
            }
        }

        public KeeleyTypeIds KeeleyTypeIDAsEnum
        {
            get
            {
                return (KeeleyTypeIds)KeeleyTypeId;
            }
        }
    }
}
