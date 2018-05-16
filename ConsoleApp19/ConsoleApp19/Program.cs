using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C = 0;
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
                if (A < B & B < C)
                {
                    Console.WriteLine("Los numeros {0} , {1} y {2} fueron ingresados de menor a mayor", A, B, C);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No se ingresaron los numeros de menor a mayor");
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
