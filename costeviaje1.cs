using System;

namespace costtravel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("vamos a calcular el coste de gasolina del viaje;");
            Console.WriteLine("dime cuantos kms vas a recorrer?");
            double kilometrosRecorridos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la gasolina");
            double precioGasolina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el consumo de tu coche");
            double precioconsumo = Convert.ToDouble(Console.ReadLine());


            double kilometrosPasados = kilometrosRecorridos / 100;
            double consumoviaje = kilometrosRecorridos * kilometrosPasados;
            double precioviaje = consumoviaje / precioGasolina; 

            Console.WriteLine($"el viaje de {kilometrosRecorridos} kilometros te costara {precioviaje}");



        }
    }
}
