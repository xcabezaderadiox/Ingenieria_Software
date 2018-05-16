using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año:");
            string año = Console.ReadLine();
            int x = int.Parse(año);
            int a = x % 19;
            int b = x % 4;
            int c = x % 7;
            int d = (19 * a + 24) % 30;
            int e = (2 * b + 4 * c + 6 * d + 5) % 7;
            int pascua = 22 + d + e;
            Console.WriteLine("La fecha de pascua del año {0} es el Domingo {1} de Marzo", x, pascua);
            Console.ReadKey();
        }
    }
}
