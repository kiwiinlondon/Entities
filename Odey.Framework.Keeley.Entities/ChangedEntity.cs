using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    [DataContract]
    public class ChangedEntity
    {
        [DataMember]
        public int EntityID { get; set; }

        [DataMember]
        public EntityState EntityState { get; set; }

        [DataMember]
        public EntityTypeIds EntityTypeId { get; set; }
    }
}
