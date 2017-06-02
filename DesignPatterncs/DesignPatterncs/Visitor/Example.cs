using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Visitor
{
    /// <summary>
    /// Element
    /// </summary>
    public class Example : Element
    {
        private string MaterialName;
        private string ColourName;
        private string ExampleName;


        public Example(string MatName, string ColName, string ExName)
        {
            MaterialName = MatName;
            ColourName = ColName;
            ExampleName = ExName;
        }

        public override void Accept(IVisitor visit)
        {
            visit.Visit(this);
        }

        public override string getColour()
        {
            return ColourName;
        }

        public override string getMaterial()
        {
            return MaterialName;
        }

        public override string getName()
        {
            return ExampleName;
        }

    }
}
