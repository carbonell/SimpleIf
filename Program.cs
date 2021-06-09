using System;

namespace ThirdExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que captura una letra y te dice si es la letra A mayúscula");
            Console.WriteLine("Coloque una letra: ");
            var letter = Console.ReadLine();
            if (letter == "A")
            {
                Console.WriteLine("La letra es una A mayúscula!!");
            }
        }
    }
}
