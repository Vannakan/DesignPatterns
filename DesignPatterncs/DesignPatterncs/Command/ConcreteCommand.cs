using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Command
{
    class ConcreteCommand : Command
    {
        private Receiver _receiver;


        public ConcreteCommand(Receiver receive)
        {
            Console.WriteLine("Receiver set");
            _receiver = receive;
        }

        public void Execute()
        {
            Console.WriteLine("Calling receivers action");
            _receiver.Action();
        }
    }
}
