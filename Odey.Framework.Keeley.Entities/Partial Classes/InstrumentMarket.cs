using System;
using System.Collections.Generic;
using System.Linq;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    partial class InstrumentMarket
    {

        public InstrumentMarket()
        {
        }
        

        public InstrumentMarket(Instrument instrument)
            : this()
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

        public Bond Bond
        {
            get
            {
                return Instrument.Bond;
            }
        }

        public bool Is13F
        {
            get
            {
                return Instrument.Is13F;
            }
        }

        public int InstrumentClassID
        {
            get
            {
                return Instrument.InstrumentClassID;
            }
        }

        public InstrumentClassIds InstrumentClassIdAsEnum
        {
            get
            {
                return (InstrumentClassIds)InstrumentClassID;
            }
        }

        public ParentInstrumentClassIds ParentInstrumentClassIdAsEnum
        {
            get
            {
                return Instrument.ParentInstrumentClassIdAsEnum;
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

        public string Cusip
        {
            get
            {
                return Instrument.Cusip;
            }
        }

        public string PrimaryBloombergGlobalId
        {
            get
            {
                return Instrument.BloombergGlobalId;
            }
        }

        public DateTime? ForwardDate
        {
            get
            {
                return Instrument.ForwardDate;
            }
        }

        public string PrimaryBloombergTicker
        {
            get
            {
                return Instrument.BloombergTicker;
            }
        }      

        public InstrumentMarket CalculatedUnderlyingInstrumentMarket
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
                        return Instrument.Underlyer.InstrumentMarkets.First();
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
    }
}

