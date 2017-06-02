using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Visitor
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visit);
        public abstract string getMaterial();
        public abstract string getColour();
        public abstract string getName();
    }
}
