using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca el operando1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el operando2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Que operacion desea Realizar?");
            string operacion = Console.ReadLine();

            switch (operacion)
            {
                case1: Console.WriteLine("SUMA");
            Console.WriteLine("Suma {0} +{1} = {2}", num1, num2, num1 + num2);
            break;
        case2: Console.WriteLine("RESTA");
            Console.WriteLine("RESTA {0}-{1} ={2}", num1, num2, num1 - num2);
            break;
        case3: Console.WriteLine("MULTIPLICACION");
            Console.WriteLine("Multiplicacion {0}*{1} = {2}", num1, num2, num1 * num2);
            break;
        case4: Console.WriteLine("DIVISION");
            Console.WriteLine("DIVISION {0}/{1} = {2}", num1, num2, num1 / num2);
            break;
        case5: Console.WriteLine("RESTO");
            Console.WriteLine("RESTO{0}%{1} ={2}", num1, num2, num1 % num2);
            break;
        }







        




