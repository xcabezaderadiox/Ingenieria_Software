using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            Console.WriteLine("Ingrese primer numero: ");
            string primero = Console.ReadLine();
            a = int.Parse(primero);

            Console.WriteLine("Ingrese el segundo numero: ");
            string segundo = Console.ReadLine();
            b = int.Parse(segundo);

            if (a < b)
            {
                Console.WriteLine("El primer numero {0} es menor al segundo {1}", a, b);
                Console.ReadKey();
            }
            else if (b < a)
            {
                Console.WriteLine("El segundo numero {0} es menor al primero {1}", b, a);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El primer numero {0} es igual al segundo {1}", a, b);
            }
        }
    }
}
