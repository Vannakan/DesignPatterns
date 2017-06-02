using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Adapter
{
    public class MyAdapter : Adaptee, ITarget
    {
       
        public MyAdapter()
        {

        }

        public void Request()
        {
            SpecificRequest();
        }
    }
}
