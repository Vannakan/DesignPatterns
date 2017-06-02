using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Visitor
{
    class MaterialVisitor : IVisitor
    {
        public void Visit(Element e)
        {
            Example a = e as Example;
            Console.WriteLine("(Material Visitor) --- Example Name --- " + a.getName() +  " --- Detected Material --- " + a.getMaterial());
        }

     
    }
}
