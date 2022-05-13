using Bootcamp.Entities;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 25, "White Wazard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());

        }
    }
}
