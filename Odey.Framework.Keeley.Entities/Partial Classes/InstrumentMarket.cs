using System;

namespace Odey.Framework.Keeley.Entities
{
    partial class InstrumentMarket
    {

        protected InstrumentMarket()
        {
        }

        public InstrumentMarket(Instrument instrument)
        {
            Instrument = instrument;
        }

        public int IssuerID
        {
            get
            {
                return Instrument.IssuerID;
            }
        }

        public int InstrumentClassID
        {
            get
            {
                return Instrument.InstrumentClassID;
            }
        }

        public int IssueCurrencyID
        {
            get
            {
                return Instrument.IssueCurrencyID;
            }
        }

        public string Isin
        {
            get
            {
                return Instrument.Isin;
            }
        }


        public string Name
        {
            get
            {
                return Instrument.Name;
            }
        }

        public string LongName
        {
            get
            {
                return Instrument.LongName;
            }
        }
    }
}

