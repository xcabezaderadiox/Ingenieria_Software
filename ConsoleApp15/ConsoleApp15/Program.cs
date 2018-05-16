using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            Console.WriteLine("Ingrese un numero: ");
            try
            {
                string linea = Console.ReadLine();
                A = int.Parse(linea);
                if (A % 2 == 0)
                {
                    Console.WriteLine("El numero ingresado es par");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El numero es impar");
                    Console.ReadKey();

                }
            }
            catch
            {
                Console.WriteLine("Solo ingrese numeros");
                Console.ReadKey();
                return;
            }
        }
    }
}
