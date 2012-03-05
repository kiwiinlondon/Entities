using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    partial class Instrument
    {
        public Instrument Underlyer
        {
            get
            {
                if (UnderlyingRelationship != null)
                {
                    return UnderlyingRelationship.Underlyer;
                }
                else
                {
                    return null;
                }
            }
        }

        public InstrumentClassIds InstrumentClassIdAsEnum
        {
            get
            {
                return (InstrumentClassIds)InstrumentClassID;
            }
        }
    }
}
