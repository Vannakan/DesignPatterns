using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler successor = null;

        public int Level { get; set; }

        public void SetSuccessor(Handler handler)
        {
            successor = handler;
        }

        public virtual void ProcessRequest(int DifficultyOfRequest)
        {
            if (DifficultyOfRequest > Level)
            {
                if (successor != null)
                {
                    Console.WriteLine("Unable to handle request, insufficient level, requesting successor");
                    successor.ProcessRequest(DifficultyOfRequest);
                }
            }
            else if(DifficultyOfRequest <= Level)
            {
                Console.WriteLine("Processed a level " + Level + " Order from " + this);
            }

            
        }
        

        
    }
}
