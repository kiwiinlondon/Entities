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
            return String.Format("Client Account: ClientAccountId = {0}, ClientId={1}, AdministratorId={2}, FundId={3}, Name={4}", this.ClientAccountId, this.ClientId, this.AdministratorId, this.FundId, this.Name);
        }
    }
}
