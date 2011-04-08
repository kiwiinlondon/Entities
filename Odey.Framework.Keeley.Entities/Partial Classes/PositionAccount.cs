using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class PositionAccount
    {
        public int InstrumentMarketId
        {
            get
            {
                return Position.InstrumentMarketID;
            }
        }

        public int BookId
        {
            get
            {
                return Position.BookID;
            }
        }

        public int CurrencyId
        {
            get
            {
                return Position.CurrencyID;
            }
        }
    }
}
