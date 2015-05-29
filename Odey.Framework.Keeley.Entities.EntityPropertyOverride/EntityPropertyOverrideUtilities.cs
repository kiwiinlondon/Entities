using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Odey.Framework.Keeley.Entities.Caches;

namespace Odey.Framework.Keeley.Entities.EntityPropertyOverrides
{
    public static class EntityPropertyOverrideUtilities<T>
    {
        private static EntityType GetEntityType(Type entityType)
        {
            EntityTypeCache cache = new EntityTypeCache();
            return cache.Get(entityType.FullName);

        }
        private static int GetId(T entity, Type typeOfEntity, EntityType entityType)
        {
            PropertyInfo propInfo = typeOfEntity.GetProperty(entityType.PrimaryKey.Name);
            object primarykeyValue = propInfo.GetValue(entity);
            return (int)primarykeyValue;

        }

        public static void ApplyOverrides(T entity, KeeleyModel context)
        {
            Type typeOfEntity = entity.GetType();
            EntityType entityType = GetEntityType(typeOfEntity);
            int entityId = GetId(entity,typeOfEntity, entityType);
            
            if (entityId != default(int))
            {
                List<EntityPropertyOverride> overrides = context.EntityPropertyOverrides.Where(a => a.EntityID == entityId && a.EntityProperty.EntityTypeId == (int)entityType.EntityTypeID).ToList();
                foreach (EntityPropertyOverride propertyOverride in overrides)
                {
                    EntityProperty entityProperty = entityType.GetEntityProperty(propertyOverride.EntityPropertyId);
                    PropertyInfo propInfo = typeOfEntity.GetProperty(entityProperty.Name);
                    object value = null;
                    switch ((TypeCode)entityProperty.TypeCode)
                    {
                        case TypeCode.String:
                            value = propertyOverride.StringValue;
                            break;
                        case TypeCode.Decimal:
                            value = propertyOverride.DecimalValue;
                            break;
                        case TypeCode.Int32:
                            value = propertyOverride.IntValue;
                            break;
                        case TypeCode.DateTime:
                            value = propertyOverride.DateTimeValue;
                            break;
                    }
                    propInfo.SetValue(entity, value, null);
                }
            }
        }

        public static void SaveOverrides(T entity, KeeleyModel context)
        {

        }
    }
}
