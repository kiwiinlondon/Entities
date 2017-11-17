using Odey.Framework.Keeley.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities
{
    public class MessageQueueTypeConfiguration
    {
        public MessageQueueTypeConfiguration(Type type, List<string> properties, MessageTypeIds? messageTypeId)
        {
            Type = type;
            Properties = properties;
            if (messageTypeId.HasValue)
            {
                MessageTypeId = messageTypeId.Value;
            }
            else
            {
                MessageTypeIds lookedUpMessageTypeId;
                if (!MessageTypeMappings.TryGetValue(type, out lookedUpMessageTypeId))
                {
                    throw new ApplicationException($"unknown type for messaging {type}");
                }
                MessageTypeId = lookedUpMessageTypeId;
            }

        }
        public Type Type { get; private set; }

        public List<string> Properties { get; private set; }

        public MessageTypeIds MessageTypeId { get; private set; }



        private static readonly Dictionary<Type, MessageTypeIds> MessageTypeMappings = new Dictionary<Type, MessageTypeIds>
        {
            {typeof( AttributionPnl), MessageTypeIds.AttributionPnl},
            {typeof( Portfolio), MessageTypeIds.Portfolio}
        };
    }
}
