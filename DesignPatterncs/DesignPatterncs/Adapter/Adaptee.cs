using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Adapter
{
    public class Adaptee 
    {
        public void SpecificRequest()
        {
            Console.WriteLine("This is important information");
        }
    }
}
