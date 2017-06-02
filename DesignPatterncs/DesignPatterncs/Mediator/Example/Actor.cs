using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Mediator.Example
{
   public class Actor : Participant
    {

        public Actor(ChatRoom room, string name) : base (room,name)
        {

        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("(ACTOR)");
            base.Receive(from, message);
        }
    }
}
