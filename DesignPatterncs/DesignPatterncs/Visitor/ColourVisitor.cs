using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Visitor
{
    class ColourVisitor : IVisitor
    {
        public void Visit(Element b)
        {
            Example a = b as Example;
            Console.WriteLine("(Colour Visitor)   --- Example Name --- " + a.getName() + " --- Detected Colour   --- " + a.getColour());

        }


    }
}
