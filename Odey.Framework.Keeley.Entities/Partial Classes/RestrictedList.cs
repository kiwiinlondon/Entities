using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities
{
    public partial class RestrictedList : IObjectWithState
    {
       
        #region IObjectWithState Members

        [DataMember]
        public State State {get;set;}

        [DataMember]
        public Dictionary<string, object> OriginalValues{get;set;}
       

        #endregion
    }
}
