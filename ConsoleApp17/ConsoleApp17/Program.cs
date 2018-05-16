using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B = 0;
            Console.WriteLine("Ingrese primer precio:");
            try
            {
                string linea1 = Console.ReadLine();
                A = float.Parse(linea1);
                Console.WriteLine("Ingrese el segundo precio:");
                string linea2 = Console.ReadLine();
                B = float.Parse(linea2);
                if (A < B)
                {
                    Console.WriteLine("Los precios de menor a mayor son el mas barato {0} y el mas caro {1} ", A, B);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Los precios de menor a mayor son el mas barato {0} y el mas caro {1} ", B, A);
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Ingrese solo numeros");
                Console.ReadKey();
            }
        }
    }
}
