using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para visualizar la tabla");
            string numero = Console.ReadLine();
            int n = int.Parse(numero);
            Console.WriteLine("NÚMERO CUADRADO CUBO");
            for (int i = 0; i <= n; i++)
            {
                double cuadrado = Math.Pow(i, 2);
                double cubo = Math.Pow(i, 3);
                Console.WriteLine("  "+ i + "        " + cuadrado + "     " + cubo);
            }
            Console.ReadKey();
        }
    }
}
