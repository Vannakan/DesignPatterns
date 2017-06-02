using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Builder
{
    public class CarBuilder : Builder
    {


        public override void SetTopSpeed()
        {
            _car.TopSpeed = 120;
        
        }
        public override void SetAutomatic()
        {
            _car.Automatic = true;
        }

        public override void SetColour()
        {
            _car.Colour = "Green";
        }

        public override void SetYear()
        {
            _car.Year = 1998;
        }

        public override void SetType()
        {
            _car.type = CarType.Normal;
        }

    }
}
