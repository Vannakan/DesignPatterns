using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Mediator.Example
{
   public abstract class AbstractChatroom
    {
        public abstract void Register(Participant p);
        public abstract void Send(string from, string to, string message);
    }
}
