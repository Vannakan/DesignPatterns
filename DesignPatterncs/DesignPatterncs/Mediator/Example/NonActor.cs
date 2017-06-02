using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Mediator.Example
{
   public class NonActor : Participant
    {
        public NonActor(ChatRoom chat, string name) : base(chat,name)
        {

        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("(NON ACTOR)");
            base.Receive(from, message);
        }
    }
}
