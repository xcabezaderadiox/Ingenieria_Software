using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B ,C = 0;
            Console.WriteLine("Hola zapatero por favor ingrese los pares de zapatos: ");
            try
            {
                string linea = Console.ReadLine();
                A = int.Parse(linea);
                Console.WriteLine("Ingrese los nuevos pares:");
                string linea2 = Console.ReadLine();
                B = int.Parse(linea2);
                C = A + B;
                Console.WriteLine("La cantidad total de zapatos ingresados es {0}", C);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ingrese solo cantidad de pares");
                Console.ReadKey();
                return;

            }



        }
    }
}
