using System;

namespace Odey.Framework.Keeley.Entities
{
    partial class InstrumentMarket
    {

        public InstrumentMarket()
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




        public InstrumentMarket UnderlyingInstrumentMarket
        {
            get
            {
                if (Instrument.Underlyer != null)
                {
                    if (Instrument.Underlyer.InstrumentMarkets.Count == 0)
                    {
                        return null;
                    }
                    else if (Instrument.Underlyer.InstrumentMarkets.Count == 1)
                    {
                        return Instrument.Underlyer.InstrumentMarkets[0];
                    }
                    else
                    {
                        throw new ApplicationException(String.Format("Unable to establish underlying instrument market {0}", Instrument.InstrumentID));
                    }
                }
                else
                {
                    return null;
                }
            }
        }
      
    }
}

