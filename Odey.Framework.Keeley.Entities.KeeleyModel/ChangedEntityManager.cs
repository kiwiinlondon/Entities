using Newtonsoft.Json;
using Odey.Framework.Infrastructure.Contracts;
using Odey.Framework.Keeley.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities
{
    internal class ChangedEntityManager
    {
        internal ChangedEntityManager()
        {
        }


        private static readonly Dictionary<Type, MessageQueueTypeConfiguration> _changedTypesForMessages
            = new Dictionary<Type, MessageQueueTypeConfiguration>()
            {
                {typeof(AttributionPnl), new MessageQueueTypeConfiguration(typeof(AttributionPnl),null,MessageTypeIds.AttributionPnl) },
                {typeof(Portfolio), new MessageQueueTypeConfiguration(typeof(Portfolio),null,MessageTypeIds.Portfolio) }
            };

        Dictionary<DbEntityEntry, ChangedEntity> _changedEntitiesByEntry = new Dictionary<DbEntityEntry, ChangedEntity>();
        List<Tuple<ChangedEntity,MessageTypeIds>> _changedEntitiesForMessageQueue = new List<Tuple<ChangedEntity, MessageTypeIds>>();

        public List<ChangedEntity> ChangedEntities => _changedEntitiesByEntry.Values.ToList();

        public void AddChangedEntity(KeeleyModel context, DbEntityEntry entry)
        {

            var changedEntity = GetChangedEntity(context, entry);
            _changedEntitiesByEntry.Add(entry, changedEntity);
            AddToMessageQueue(entry, changedEntity);
        }

        private void AddToMessageQueue(DbEntityEntry entry,ChangedEntity changedEntity)
        {
            bool add = false;
            MessageQueueTypeConfiguration config;
            if (_changedTypesForMessages.TryGetValue(entry.Entity.GetType(), out config))
            {
                if (entry.State == System.Data.EntityState.Modified)
                {
                    IEnumerable<string> properties;
                    if (config.Properties == null)
                    {
                        properties = entry.CurrentValues.PropertyNames;
                    }
                    else
                    {
                        properties = config.Properties;
                    }

                    foreach (var property in properties)
                    {                        
                        AddIfPropertyChanged(changedEntity, property, entry, ref add);
                    }

                }
                else
                {
                    add = true;
                }
                if (add)
                {
                    _changedEntitiesForMessageQueue.Add(new Tuple<ChangedEntity,MessageTypeIds>(changedEntity, config.MessageTypeId));
                }
            }
        }

        private void AddIfPropertyChanged(ChangedEntity changedEntity,string property, DbEntityEntry entry, ref bool addEntity)
        {
            bool addField = false;
            object originalValue = entry.OriginalValues[property];
            object currentValue = entry.CurrentValues[property];

            if (originalValue == null || currentValue == null)
            {
                if (!(originalValue == null && currentValue == null))
                {
                    addField = true;
                }
            }
            else if (!originalValue.Equals(currentValue))
            {
                addField = true;
            }
            if (addField)
            {
                changedEntity.ChangedProperties.Add(property, new ChangedProperty(property, originalValue, currentValue));
                addEntity = true;
            }
        }

        private ChangedEntity GetChangedEntity(KeeleyModel context,DbEntityEntry entry)
        {
            ChangedEntity changedEntity = new ChangedEntity(entry.Entity.GetType(), entry.State);
            if (entry.State == EntityState.Deleted)
            {
                changedEntity.Key = GetPrimaryKeyValue(context,entry);
            }
            AddUsefulFields(entry, changedEntity);
            return changedEntity;
        }

        public void EnhanceChangedEntities(KeeleyModel context)
        {
            foreach (KeyValuePair<DbEntityEntry, ChangedEntity> change in _changedEntitiesByEntry)
            {
                if (change.Value.EntityState != EntityState.Deleted)
                {
                    change.Value.Key = GetPrimaryKeyValue(context,change.Key);
                }
            }

        }

        public void SendMessages(KeeleyModel context,string source)
        {
            foreach (var changedEntity in _changedEntitiesForMessageQueue)
            {
                foreach(var key in changedEntity.Item1.Key)
                {
                    changedEntity.Item1.UsefulProperties.Add(key.Key, key.Value);
                }
                
                string properties = null;
                string originalValues = null;
                string currentValues = null;
                if (changedEntity.Item1.ChangedProperties.Count > 0)
                {
                    properties = string.Join(",", changedEntity.Item1.ChangedProperties.Select(a => a.Key));
                    originalValues = string.Join(",", changedEntity.Item1.ChangedProperties.Select(a => a.Value.OriginalValue));
                    currentValues = string.Join(",", changedEntity.Item1.ChangedProperties.Select(a => a.Value.CurrentValue));
                }
                context.MessageQueue_Insert((int)changedEntity.Item2, JsonConvert.SerializeObject(changedEntity.Item1.UsefulProperties).ToString(),
                    GetStateChar(changedEntity.Item1.EntityState), source, properties, originalValues, currentValues);
            }
        }

        private string GetStateChar(EntityState entityState)
        {
            switch (entityState)
            {
                case EntityState.Added:
                    return "A";
                case EntityState.Deleted:
                    return "D";
                case EntityState.Modified:
                    return "M";
                default:
                    throw new ApplicationException("Unknown Entity State");

            }
        }


        private EntityKeyMember[] GetPrimaryKeyValue(KeeleyModel context,DbEntityEntry entry)
        {
            var objectStateEntry = ((IObjectContextAdapter)context).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
            return objectStateEntry.EntityKey.EntityKeyValues;
        }

        private void AddUsefulFields(DbEntityEntry entry, ChangedEntity changedEntity)
        {
            Type entityType = entry.Entity.GetType();

            DbPropertyValues values;
            if (entry.State == EntityState.Deleted)
            {
                values = entry.OriginalValues;
            }
            else
            {
                values = entry.CurrentValues;
            }

            if (entityType == typeof(AttributionPnl))
            {
                AddValueToUsefulProperties(changedEntity, values, "FundId");
                AddValueToUsefulProperties(changedEntity, values, "AttributionSourceId");
                AddValueToUsefulProperties(changedEntity, values, "ReferenceDate");
                AddValueToUsefulProperties(changedEntity, values, "CurrencyId");
                AddValueToUsefulProperties(changedEntity, values, "PositionID");
                AddValueToUsefulProperties(changedEntity, values, "PnlTypeId");

            }

            if (entityType == typeof(Portfolio))
            {
                AddValueToUsefulProperties(changedEntity, values, "FundId");
                AddValueToUsefulProperties(changedEntity, values, "PositionId");
                AddValueToUsefulProperties(changedEntity, values, "ReferenceDate");
            }
            else if (entityType == typeof(PortfolioEvent))
            {
                AddValueToUsefulProperties(changedEntity, values, "PositionId");
                AddValueToUsefulProperties(changedEntity, values, "ReferenceDate");
            }
            else if (entityType == typeof(Instrument))
            {
                AddValueToUsefulProperties(changedEntity, values, "InstrumentClassID");
            }
            else if (entityType == typeof(InstrumentMarket))
            {
                AddValueToUsefulPropertiesUsingReflection(entry, "InstrumentClassID", changedEntity);
            }
            else if (entityType == typeof(FundPerformance))
            {
                AddValueToUsefulPropertiesUsingReflection(entry, "FundId", changedEntity);
            }
            else if (entityType == typeof(Analytic))
            {
                AddValueToUsefulPropertiesUsingReflection(entry, "AnalyticTypeID", changedEntity);
            }
        }
        private void AddValueToUsefulProperties(ChangedEntity changedEntity, DbPropertyValues currentValues, string key)
        {
            changedEntity.UsefulProperties.Add(key, currentValues[key]);
        }

        private void AddValueToUsefulPropertiesUsingReflection(DbEntityEntry entry, string key, ChangedEntity changedEntity)
        {
            PropertyInfo propInfo = entry.Entity.GetType().GetProperty(key);
            object value = propInfo.GetValue(entry.Entity, null);
            changedEntity.UsefulProperties.Add(key, value);
        }

    }
}
