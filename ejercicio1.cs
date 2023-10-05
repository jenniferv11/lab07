using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07_ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());
            float resultado = 0f;

            for (int i = 0; i <= n; i++)
            {
                resultado = (16.0f - (float)i) / (3.0f * i);
                Console.WriteLine("El resultado es: " + resultado);
            }
            Console.ReadKey();
        }
    }
}
