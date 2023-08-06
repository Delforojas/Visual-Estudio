using System;

namespace ConsoleApp123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cantidad de euros:");
            const euros = Convert.ToDouble(Console.ReadLine());
            double pesetas = euros * 166;
            Console.WriteLine("{0} euros son {1}", euros, pesetas);
            Console.WriteLine($"{euros} euros equivale a {pesetas} pesetas.");
        }
    }
}
