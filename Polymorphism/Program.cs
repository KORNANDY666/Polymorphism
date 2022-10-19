namespace Polymorphism                                 // Andreas Blom YH.Net -22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creates 3 object , which inherit from the Tekning class.
            Tekning C = new Cirkel();
            Tekning F = new Fyrkant();
            Tekning R = new Rektangel();


            // create an array into which I put my objects and print them out in a foreach loop.
            Tekning[] tekning = { C,F,R};
            foreach (var item in tekning)
            {
                item.Area();
            }
        }
    }
}