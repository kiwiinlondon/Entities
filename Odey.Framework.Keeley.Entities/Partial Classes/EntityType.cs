using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class EntityType   
    {
        private EntityProperty _primarykey;

        public EntityProperty PrimaryKey
        {
            get
            {
                if (_primarykey == null)
                {
                    _primarykey = EntityProperties.FirstOrDefault(a => a.IsPrimaryKey);
                }
                return _primarykey;
            }
        }

        Dictionary<int,EntityProperty> _entityPropertyHashed;
        public EntityProperty GetEntityProperty(int entityPropertyId)
        {
            if (_entityPropertyHashed == null)
            {
                _entityPropertyHashed = EntityProperties.ToDictionary(a => a.EntityPropertyID, a => a);
            }
            return _entityPropertyHashed[entityPropertyId];
        }
    }
}
