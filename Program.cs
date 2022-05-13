using Bootcamp.Entities;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 25, "White Wazard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));

        }
    }
}
