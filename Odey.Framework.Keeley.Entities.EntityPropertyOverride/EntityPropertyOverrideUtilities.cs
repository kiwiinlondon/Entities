using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Odey.Framework.Keeley.Entities.Caches;
using System.Data.Entity.Infrastructure;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities.EntityPropertyOverrides
{
    public static class EntityPropertyOverrideUtilities
    {
        private static EntityType GetEntityType(Type entityType)
        {
            EntityTypeCache cache = new EntityTypeCache();
            return cache.Get(entityType.FullName);

        }
        private static int? GetId<T>(T entity, Type typeOfEntity, EntityType entityType)
        {           
            EntityProperty primarykey = entityType.PrimaryKey;
            if (primarykey != null)
            {
                PropertyInfo propInfo = typeOfEntity.GetProperty(primarykey.Name);
                object primarykeyValue = propInfo.GetValue(entity);
                return (int)primarykeyValue;
            }
            return null;

        }

        public static void ApplyOverrides(KeeleyModel context)
        {
            IEnumerable<object> modifiedEntities = context.GetModifiedEntities().Values;
            foreach (object modifiedEntity in modifiedEntities)
            {
                ApplyOverrides(modifiedEntity, context);
            }
        }

        private static void ApplyOverrides<T>(T entity, KeeleyModel context)
        {
            Type typeOfEntity;
            EntityType entityType;
            int? entityId;
            GetEntityDetails(entity, out typeOfEntity, out entityType, out entityId);
            if (entityId.HasValue)
            {
                List<EntityPropertyOverride> overrides = context.EntityPropertyOverrides.Where(a => a.EntityID == entityId && a.EntityProperty.EntityTypeId == entityType.EntityTypeID).ToList();
                ApplyOverrides(entity, context, overrides, entityId.Value, entityType, typeOfEntity);
            }
        }

        private static void GetEntityDetails<T>(T entity, out Type typeOfEntity, out EntityType entityType, out int? entityId)
        {
            typeOfEntity = entity.GetType();
            entityType = GetEntityType(typeOfEntity);
            if (entityType == null)
            {
                entityId = null;
            }
            else
            {
                entityId = GetId(entity, typeOfEntity, entityType);
            }
        }

        

        private static void ApplyOverrides<T>(T entity, KeeleyModel context, IEnumerable<EntityPropertyOverride> overrides, int entityId, EntityType entityType, Type typeOfEntity)
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

        public static void CreateOrUpdateOverrides(KeeleyModel context, EntityPropertyIds[] entityPropertyIdsThatCanBeOverriden)
        {
            if (entityPropertyIdsThatCanBeOverriden != null && entityPropertyIdsThatCanBeOverriden.Count() > 0)
            {
                foreach (var modifiedEntity in context.GetModifiedEntities())
                {
                    var entity = modifiedEntity.Key;
                    Type typeOfEntity;
                    EntityType entityType;
                    int? entityId;
                    GetEntityDetails(entity, out typeOfEntity, out entityType, out entityId);

                    if (entityId.HasValue)
                    {
                        List<EntityProperty> entityProperties = entityType.EntityProperties.Where(a => entityPropertyIdsThatCanBeOverriden.Contains((EntityPropertyIds)a.EntityPropertyID)).ToList();

                        if (entityProperties.Count() > 0)
                        {
                            int[] entityPropertyIds = entityProperties.Select(a => a.EntityPropertyID).ToArray();
                            Dictionary<int, EntityPropertyOverride> existingOverrides = context.EntityPropertyOverrides
                                .Where(a => a.EntityID == entityId && entityPropertyIds.Contains(a.EntityPropertyId)).ToDictionary(a => a.EntityPropertyId, a => a);

                            CreateOrUpdateOverrides(entity, context, entityProperties, entityType, typeOfEntity, entityId.Value, modifiedEntity.Value, existingOverrides);
                        }
                    }
                }
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
