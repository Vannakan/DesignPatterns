using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Visitor
{
    /// <summary>
    /// Object Structure Class
    /// </summary>
    public class Examples
    {
        private List<Example> _examples = new List<Example>();

        public void Add(Example ex)
        {
            _examples.Add(ex);
        }

        public void Remove(Example ex)
        {
            _examples.Remove(ex);
        }

        public void Accept(IVisitor visit)
        {
            foreach(Example e in _examples)
            {
                e.Accept(visit);
            }
        }

        public Example getExample(int i)
        {
            return _examples[i];
        }
    }
}
