using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class ClientAccount    
    {
        public override string ToString()
        {
            return String.Format("Client Account: ClientAccountId = {0}, AccountReference={1}, ClientId={2}, AdministratorId={3}, FundId={4}, Name={5}", this.ClientAccountId, this.AccountReference, this.ClientId, this.AdministratorId, this.FundId, this.Name);
        }
    }
}
