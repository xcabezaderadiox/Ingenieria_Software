using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            double lc1, lc2, h = 0;
            Console.WriteLine("Ingrese el valor del primer cateto: ");
            string cateto1 = Console.ReadLine();
            lc1 = double.Parse(cateto1);

            Console.WriteLine("Ingrese el valor del segundo cateto: ");
            string cateto2 = Console.ReadLine();
            lc2 = double.Parse(cateto2);

            //Math.Sqrt me da la raiz cuadrada
            h = Math.Sqrt(Math.Pow(lc1,2) + Math.Pow(lc2,2));

            Console.WriteLine("La hipotenusa del triangulo rectangulo es {0}: ",h);
            Console.ReadKey();

        }
    }
}
