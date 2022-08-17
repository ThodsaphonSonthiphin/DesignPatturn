using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoP
{
    public abstract class Handler
    {
        protected Handler Successor = null;

        public Handler SetSuccessor(Handler handler)
        {
            this.Successor = handler;
            return handler;
        }

        public abstract bool HandleRequest(User user);
    }
}
