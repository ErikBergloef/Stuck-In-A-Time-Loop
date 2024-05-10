using System;

namespace Stuck
{
    class Abracadabra
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was the number the wizard gave you?");
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i < magicNumber + 1; i++) 
            { 
            Console.WriteLine(i + " " + "Abracadabra");
            }

        }
    }
}
