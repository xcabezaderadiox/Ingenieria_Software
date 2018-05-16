using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B = 0;
            Console.WriteLine("Ingrese el primer tiempo:");
            try
            {
                string linea1 = Console.ReadLine();
                A = float.Parse(linea1);
                Console.WriteLine("Ingrese el segundo tiempo:");
                string linea2 = Console.ReadLine();
                B = float.Parse(linea2);
                if (A < B)
                {
                    Console.WriteLine("Los resultados de la carrera son el mas lento {0} y el mas rapido {1} ", A, B);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Los resultados de la carrera son el mas lento {0} y el mas rapido {1} ", B, A);
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Ingrese solo velocidades");
                Console.ReadKey();
            }
        }
    }
}
