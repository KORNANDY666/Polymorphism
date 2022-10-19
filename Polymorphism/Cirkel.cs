using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cirkel : Tekning
    {
        // Creats the variables i need to calcuate Cirkel
        double Radius { get; set; }


        // Constructor into which I insert the values ​​of the variables.
        public Cirkel() 
        {
            Radius = 5.8;
            
        }

        // The inherited method that returns the result of the calculation.
        public override double Area()
        {
            double area = (Radius * Radius) * 3.14;
            double result = Math.Round(area,2);

            Console.WriteLine("Area Cirkel : " + result);
            return result;
        }
    }
}
