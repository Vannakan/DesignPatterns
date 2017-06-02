using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Builder
{

    public enum CarType { SuperCar, Normal}
    /// <summary>
    /// The Product class for the Builder pattern
    /// </summary>
    public class Car : Product
    {
        public int TopSpeed { get; set; }
        public int Year { get; set; }
        public bool Automatic { get; set; }
        public string Colour { get; set; }
        public CarType type { get; set;}
    }
}
