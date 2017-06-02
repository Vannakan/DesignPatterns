using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Composite
{
    public class CompositeItem : Component
    {
        List<Component> ChildList = new List<Component>();

        public int BranchID { get; set; }

        public void CallMethod() { Console.WriteLine("Branch " + BranchID + " contains  " + ChildList.Count + " Children");

            for (int i = 0; i < ChildList.Count; i++)
            {
                ChildList[i].CallMethod();
            }
        }

        public void AddChild(Component comp)
        {
            if (comp != null)
                ChildList.Add(comp);
        }

        public void RemoveChild(Component comp)
        {
            for (int i = 0; i < ChildList.Count; i++)
            {
                if(ChildList[i] == comp)                
                    ChildList.RemoveAt(i);               
            }
        }
    }
}
