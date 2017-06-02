using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Visitor
{
    public interface IVisitor
    {
        void Visit(Element e);
    }
}
