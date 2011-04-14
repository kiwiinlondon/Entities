using System;

namespace Odey.Framework.Keeley.Entities
{
    partial class FX
    {

        public int CounterpartyId
        {
            get
            {
                return FXTradeEvent.CounterpartyId;
            }
        }

        public decimal PayAmount        
        {
            get
            {
                return FXTradeEvent.PayAmount;
            }
        }

        public decimal ReceiveAmount
        {
            get
            {
                return FXTradeEvent.ReceiveAmount;
            }
        }

        public decimal ReceiveBookXrate
        {
            get
            {
                return FXTradeEvent.ReceiveBookXrate;
            }
        }

        public decimal PayBookXrate
        {
            get
            {
                return FXTradeEvent.PayBookXrate;
            }
        }
        public int PayCurrencyId
        {
            get
            {
                return FXTradeEvent.PayCurrencyId;
            }
        }

        public int ReceiveCurrencyId
        {
            get
            {
                return FXTradeEvent.ReceiveCurrencyId;
            }
        }

        public bool IsProp
        {
            get
            {
                return FXTradeEvent.IsProp;
            }
        }

        public int FMContId
        {
            get
            {
                return Instrument.FMInstId.Value;
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