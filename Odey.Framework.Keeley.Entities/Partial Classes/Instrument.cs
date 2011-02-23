using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
