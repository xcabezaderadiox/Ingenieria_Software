using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            double B = 0;
            Console.WriteLine("Ingrese precio del producto: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            B = A - (A * 0.09);
            Console.WriteLine("Su precio final con descuento de 9% es de: {0} ", B);
            Console.ReadKey();
        }
    }
}
