using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class Currency
    {
        public Currency()
        {
        }
        public Currency(Instrument instrument)
        {
            Instrument = instrument;
        }

        public string IsoCode
        {
            get
            {
                return Instrument.Name;
            }
        }

        public string Name
        {
            get
            {
                return Instrument.LongName;
            }
        }
  
    }
}
