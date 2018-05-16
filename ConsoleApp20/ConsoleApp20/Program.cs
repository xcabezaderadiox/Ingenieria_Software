using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C ,P , S = 0;
            Console.WriteLine("Ingrese primer numero:");
            try
            {
                string linea1 = Console.ReadLine();
                A = int.Parse(linea1);
                Console.WriteLine("Ingrese segundo numero:");
                string linea2 = Console.ReadLine();
                B = int.Parse(linea2);
                Console.WriteLine("Ingrese tercer numero:");
                string linea3 = Console.ReadLine();
                C = int.Parse(linea3);
                if (A < 0)
                {
                    P = (A * B * C);
                    Console.WriteLine("El producto de los numeros ingresados es {0}", P);
                    Console.ReadKey();
                }
                else
                {
                    S = (A + B + C);
                    Console.WriteLine("La suma de los numeros ingresados es {0}", S);
                    Console.ReadKey();

                }
            }
            catch
            {
                Console.WriteLine("Solo ingrese numeros por favor");
                Console.ReadKey();
                return;
            }
        }
    }
}
