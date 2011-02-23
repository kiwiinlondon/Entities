using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class FX
    {

        public FX()
        {
        }

        public int? FMContId
        {
            get
            {
                return Instrument.FMInstId;
            }
        }

        public string Name
        {
            get
            {
                return Instrument.Name;
            }
        }        
    }
}

