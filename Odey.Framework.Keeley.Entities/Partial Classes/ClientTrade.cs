using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class ClientTrade
    {
         public override string ToString()
        {
            return String.Format("Client Trade: ClientAccountId = {0}, TradeReference={1}, TradeDate={2}, Quantity={3}, Price={4}",
                this.ClientAccountId, this.TradeReference,this.TradeDate,this.Quantity,this.Price);
        }
    }
}
