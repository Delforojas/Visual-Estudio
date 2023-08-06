using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vt7
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string consonantes = "bcdfghjklmnñpqrstvwxyz";
            string numeros = "0123456789";

            Console.WriteLine(frase.Replace(" ", "").ToLower());

            int totalconsonantes = 0;
            int totalSuma = 0;

            for(int i=0; i<frase.Length;i++)
            {
                if (consonantes.Contains(frase.ToLower()[i]))
                {
                    totalconsonantes++;
                    Console.Write(frase.ToUpper()[i]);
                } else if (numeros.Contains(frase[i]))
                {
                    totalSuma+= int.Parse(Convert.ToString(frase[i]));
                }
            }
            Console.WriteLine();
            Console.WriteLine(totalconsonantes);
            Console.WriteLine(totalSuma);

        }
    }
}
