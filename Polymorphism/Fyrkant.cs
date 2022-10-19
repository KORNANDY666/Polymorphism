using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Fyrkant : Tekning
    {
        // Creats the variables i need to calcuate Fyrkant
        double Height { get; set; }
        double Lenght { get; set; }

        
        //constructor into which I insert the values ​​of the variables

        public Fyrkant()
        {
            Height = 5.5;
            Lenght = 5.5;
        }

        // The inherited method that returns the result of the calculation
        public override double Area()
        {
            double area = Height * Lenght;
            Console.WriteLine("Area Fyrkant : " + area);

            return area;
        }
    }
}
