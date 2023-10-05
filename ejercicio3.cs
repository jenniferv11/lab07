using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07_ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int añoI = 1900;
            int añoF = 2023;

            Console.WriteLine("Años bisiestos desde 1900:");

            for (int i = añoI; i < añoF; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine("Año "+i);
                }
            }
            Console.ReadKey(); 
        }
    }
}
