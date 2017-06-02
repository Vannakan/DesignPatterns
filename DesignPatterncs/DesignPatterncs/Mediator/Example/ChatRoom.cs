using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Mediator.Example
{
    public class ChatRoom : AbstractChatroom
    {

        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant p)
        {
            _participants.Add(p.Name, p);
        }

        public override void Send(string from, string to, string message)
        {
            if(_participants.Keys.Contains<string>(to))
            {
                _participants[to].Receive(from, message);
            }
        }
    }
}
