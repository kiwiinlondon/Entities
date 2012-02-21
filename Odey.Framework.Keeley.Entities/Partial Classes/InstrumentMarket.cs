using System;
using System.Collections.Generic;
using System.Linq;

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

        public int? BloombergYellowKeyId
        {
            get
            {
                return Instrument.BloombergYellowKeyId;
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
                        throw new ApplicationException("Instrument if its an underlyer it must have at least one instrument market");
                    }
                    else if (Instrument.Underlyer.InstrumentMarkets.Count == 1)
                    {
                        return Instrument.Underlyer.InstrumentMarkets[0];
                    }
                    else
                    {
                        InstrumentMarket underlyer = Instrument.Underlyer.InstrumentMarkets.Where(a => a.MarketID == MarketID).FirstOrDefault();
                        if (underlyer == null)
                        {
                            underlyer = Instrument.Underlyer.InstrumentMarkets.Where(a => a.IsPrimary == true).FirstOrDefault();
                        }
                        if (underlyer != null)
                        {
                            return underlyer;
                        }
                        throw new ApplicationException(String.Format("Unable to establish underlying instrument market {0}", Instrument.InstrumentID));
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public List<InstrumentMarket> OverlyingInstrumentMarkets
        {
            get
            {
                List<InstrumentMarket> instrumentMarkets = new List<InstrumentMarket>();
                foreach (InstrumentRelationship instrumentRelationship in Instrument.OverlyingRelationships)
                {
                    if (instrumentRelationship.Overlyer != null)
                    {
                        foreach (InstrumentMarket instrumentMarket in instrumentRelationship.Overlyer.InstrumentMarkets)
                        {
                            if (instrumentMarket.UnderlyingInstrumentMarket.InstrumentMarketID == InstrumentMarketID)
                            {
                                instrumentMarkets.Add(instrumentMarket);
                            }
                        }
                    }
                }
                return instrumentMarkets;
            }
        }
      
    }
}

