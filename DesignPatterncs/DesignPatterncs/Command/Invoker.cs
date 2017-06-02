using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Command
{
    public class Invoker
    {

        private Command _commander;
        private Receiver _receiver;

        public Invoker()
        {
            _receiver = new ConcreteReceiver();
            _commander = new ConcreteCommand(_receiver);
        }

        public void CallCommand()
        {
            _commander.Execute();
        }
    }
}
