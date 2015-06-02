using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Odey.Framework.Keeley.Entities.Caches;
using System.Data.Entity.Infrastructure;

namespace Odey.Framework.Keeley.Entities.EntityPropertyOverrides
{
    public static class EntityPropertyOverrideUtilities
    {
        private static EntityType GetEntityType(Type entityType)
        {
            EntityTypeCache cache = new EntityTypeCache();
            return cache.Get(entityType.FullName);

        }
        private static int GetId<T>(T entity, Type typeOfEntity, EntityType entityType)
        {
            PropertyInfo propInfo = typeOfEntity.GetProperty(entityType.PrimaryKey.Name);
            object primarykeyValue = propInfo.GetValue(entity);
            return (int)primarykeyValue;

        }

        public static void ApplyOverrides<T>(T entity, KeeleyModel context)
        {
            Type typeOfEntity;
            EntityType entityType;
            int entityId;
            Dictionary<int, EntityPropertyOverride> overrides = GetExistingOverridesForEntity(entity, context, out typeOfEntity, out entityType, out entityId);
            ApplyOverrides(entity, context, overrides.Values, entityId, entityType, typeOfEntity);
        }

        private static Dictionary<int, EntityPropertyOverride> GetExistingOverridesForEntity<T>(T entity, KeeleyModel context, out Type typeOfEntity, out EntityType entityType, out int entityId)
        {
            typeOfEntity = entity.GetType();
            entityType = GetEntityType(typeOfEntity);
            int id = GetId(entity, typeOfEntity, entityType);
            entityId = id;
            int entityTypeId = entityType.EntityTypeID;
            return context.EntityPropertyOverrides.Where(a => a.EntityID == id && a.EntityProperty.EntityTypeId == entityTypeId).ToDictionary(a=>a.EntityPropertyId,a=>a);
        }

        public static void ApplyOverrides<T>(T entity, KeeleyModel context, IEnumerable<EntityPropertyOverride> overrides, int entityId, EntityType entityType, Type typeOfEntity)
        {
            if (entityId != default(int))
            {
                
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

        public static void CreateOrUpdateOverrides(KeeleyModel context, Dictionary<int, List<int>> entityPropertyIdsThatCanBeOverridenByEntityTypeId)
        {
            foreach (var modifiedEntity in context.GetOriginalValuesOfModifiedEntities())            
            {
                var entity = modifiedEntity.Key;
                Type typeOfEntity;
                EntityType entityType;
                int entityId;
                Dictionary<int,EntityPropertyOverride> existingOverrides = GetExistingOverridesForEntity(entity, context, out typeOfEntity, out entityType, out entityId);
                List<int> entityPropertyIds = entityPropertyIdsThatCanBeOverridenByEntityTypeId[entityType.EntityTypeID];
                List<EntityProperty> entityProperties = entityType.EntityProperties.Where(a => entityPropertyIds.Contains(a.EntityPropertyID)).ToList();
                CreateOrUpdateOverrides(entity, context, entityProperties, entityType, typeOfEntity, entityId, modifiedEntity.Value, existingOverrides);
            }
        }

        private static void SetValueOfPropertyOnOverride(EntityPropertyOverride propertyOverride, TypeCode typeCode,object value)
        {
            switch (typeCode)
            {
                case TypeCode.String:
                    propertyOverride.StringValue = (String)value;
                    break;
                case TypeCode.Decimal:
                    propertyOverride.DecimalValue = (Nullable<decimal>)value;
                    break;
                case TypeCode.Int32:
                    propertyOverride.IntValue = (Nullable<int>)value;
                    break;
                case TypeCode.DateTime:
                    propertyOverride.DateTimeValue = (Nullable<DateTime>)value;
                    break;
                default:
                    throw new ApplicationException("Unknown Type Code");
            }
        }

        private static void CreateOrUpdateOverrides<E>(E entity, KeeleyModel context, List<EntityProperty> entityPropertiesThatCanBeOverriden, EntityType entityType,Type typeOfEntity,int entityId, DbPropertyValues originalValues,Dictionary<int,EntityPropertyOverride> existingOverrides)
        {
            //Might have to take in list of overrides

            foreach (EntityProperty entityProperty in entityPropertiesThatCanBeOverriden)
            {
                EntityPropertyOverride entityPropertyOverride;
                existingOverrides.TryGetValue(entityProperty.EntityPropertyID, out entityPropertyOverride);
                var originalValue = originalValues[entityProperty.Name];

                PropertyInfo propInfo = typeOfEntity.GetProperty(entityProperty.Name);
                var currentValue = propInfo.GetValue(entity);                
                if (originalValue == null && currentValue != null || !originalValue.Equals(currentValue))
                {
                    if (entityPropertyOverride == null)
                    {
                        entityPropertyOverride = new EntityPropertyOverride();
                        context.EntityPropertyOverrides.Add(entityPropertyOverride);
                        entityPropertyOverride.EntityID = entityId;
                        entityPropertyOverride.EntityPropertyId = entityProperty.EntityPropertyID;
                    }
                    SetValueOfPropertyOnOverride(entityPropertyOverride, (TypeCode)entityProperty.TypeCode, currentValue);                    
                }
            }            
        }
    }
}
