using System;
using Bootcamp.Entities;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 25, "White Wazard",100,95);

            Console.WriteLine(arus.Attack());
            //Console.WriteLine(wizard.Attack(7));



            Random valorAleatorio = new Random();
            int meleeAtk;
            meleeAtk = valorAleatorio.Next(30);

            Random valorAle = new Random();
            int magicAtk;
            magicAtk = valorAleatorio.Next(30);


            Warrior leon  = new Warrior("Leon", 22, "Warrior", 100, 10);
            Wizard merlin  = new Wizard("Merlin", 22, "Wizard", 100, 95);
            Archer fletcher = new Archer("Fletcher", 20, "Archer", 90, 10);

            Devil firegoo = new Devil("Fire Goo", 55, "Devil", 170, 110);
            Zombi dogzombi = new Zombi("Dog Zombi", 45, "Zombi", 140, 20);

            Console.WriteLine(leon);
            Console.WriteLine(leon.Attack() + " " + meleeAtk);

            Console.WriteLine(merlin);
            Console.WriteLine(merlin.Attack(4) + " " + magicAtk);

            Console.WriteLine(fletcher);
            Console.WriteLine(fletcher.Attack(5) + " " + meleeAtk);

            Console.WriteLine(firegoo);
            Console.WriteLine(firegoo.Attack(6) + " " + magicAtk);

            Console.WriteLine(dogzombi);
            Console.WriteLine(dogzombi.Attack() + " " + meleeAtk);

        }
    }
}
