using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{

    public interface IObjectWithState { 
        State State { get; set; }
        Dictionary < string, object > OriginalValues { get; set; }
    }

    public enum State { Added, Unchanged, Deleted }

}
