using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B = 0;
            Console.WriteLine("Ingrese el precio: ");
            try
            {
                string linea = Console.ReadLine();
                A = float.Parse(linea);
                B = ((A * 0.1) + A);
                Console.WriteLine("El precio final con el incremento de 10% es {0}", B);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ingrese solo numeros");
                Console.ReadKey();
            }
        }
    }
}
