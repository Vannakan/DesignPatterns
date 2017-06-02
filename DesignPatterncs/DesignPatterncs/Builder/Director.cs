using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Builder
{
    public class Director
    {
       /// <summary>
       /// Factory
       /// </summary>
       /// <param name="builder"></param>
       /// <returns></returns>
            public Car Build( Builder builder)
        {
            builder.SetTopSpeed();
            builder.SetYear();
            builder.SetAutomatic();
            builder.SetColour();
            builder.SetType();

            Console.WriteLine("Car Type - " + builder.GetCar().type);
            Console.WriteLine("Year Manufactured - " + builder.GetCar().Year);
            Console.WriteLine("Top Speed - " + builder.GetCar().TopSpeed);
            Console.WriteLine("Automatic - " + builder.GetCar().Automatic);
            Console.WriteLine("Colour - " + builder.GetCar().Colour);

            return builder.GetCar();
        }



        }
    
}
