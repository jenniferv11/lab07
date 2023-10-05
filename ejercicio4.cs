using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07_ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de figuras que desea: ");
            int numD = int.Parse(Console.ReadLine());

            for (int i = 0; i < numD; i++)
            {
                Console.Write("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());

                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num*2; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
