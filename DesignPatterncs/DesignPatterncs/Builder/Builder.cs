using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Builder
{
   public abstract class Builder
    {
        protected readonly Car _car = new Car();
        public abstract void SetTopSpeed();
        public abstract void SetYear();
        public abstract void SetAutomatic();
        public abstract void SetColour();
        public abstract void SetType();

        public virtual Car GetCar()
        {
            return _car;
        }
    }
}
