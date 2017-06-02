using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Composite
{
    public interface Component
    {
       int BranchID { get; set; }

        void CallMethod();
        
    }
}
