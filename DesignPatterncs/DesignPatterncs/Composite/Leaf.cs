using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Composite
{
    class Leaf : Component
    {
        public int BranchID { get; set; }
        public int LeafID { get; set; }

        public void CallMethod() { Console.WriteLine("Leaf " + LeafID + " calling from " + BranchID); }

    }
}
