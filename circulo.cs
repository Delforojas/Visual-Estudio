using System;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Reliza un programa que pida un numero, y calcule el perimetro de la circunferencia y el área del
             * circulo con ese radio.Ten en cuenta que el área del círculo es a = PI * r * r , y el perímetro
             * de la circunferencia es p = 2 *PI *r.*/

            //inicializamos constante PI:
            const double pi = 3.1416;

            //solicitud de entrada de datos y asignacion a variable:
            double radio;
            Console.WriteLine("por favor introduzca radio: ");
            radio = double.Parse(Console.ReadLine());

            //calculamos y mostramos en pantalla:
            double area = radio * radio * pi;
            double perimetro = radio * pi * 2;

            Console.WriteLine("Tu cicrulo tiene un área de " + area + " y un perimetro de " + perimetro + ".");
            
        }
    }
}
