using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rektangel : Tekning
    {
        // Creats the variables i need to calcuate Rektangel.
        double Height { get; set; }
        double Width { get; set; }



        //constructor into which I insert the values ​​of the variables.
        public Rektangel()
        {
            Height = 10.50;
            Width = 15.75;
        }

        // The inherited method that returns the result of the calculation
        public override double Area()
        {
            double area = Height * Width;
            Console.WriteLine("Area Rektangel : " + area);

            return area;
        }
    }
}
