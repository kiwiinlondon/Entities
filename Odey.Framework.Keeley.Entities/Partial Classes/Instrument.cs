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


        public int ParentInstrumentClassId
        {
            get
            {
                return InstrumentClass.ParentInstrumentClassId.Value;
            }
        }

        public ParentInstrumentClassIds ParentInstrumentClassIdAsEnum
        {
            get
            {
                return (ParentInstrumentClassIds)ParentInstrumentClassId;
            }
        }

        public DateTime? ForwardDate
        {
            get
            {
                if (ForwardFX != null)
                {
                    return ForwardFX.MaturityDate;
                }
                return null;
            }
        }
    }
}
