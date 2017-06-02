using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Builder
{
    class SuperCarBuilder : Builder
    {

        public override void SetTopSpeed()
        {
            _car.TopSpeed = 180;

        }
        public override void SetAutomatic()
        {
            _car.Automatic = false;
        }

        public override void SetColour()
        {
            _car.Colour = "Red";
        }

        public override void SetYear()
        {
            _car.Year = 2006;
        }

        public override void SetType()
        {
            _car.type = CarType.SuperCar;
        }


    }
}
