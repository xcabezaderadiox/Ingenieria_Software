using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int p = 0;
            int n = 0;
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string numero = Console.ReadLine();
                a = int.Parse(numero);
                if (a < 0)
                    n = n+1;
                if (a > 0)
                    p = p+1;
            }

            Console.WriteLine("La cantidad de numeros positivos es {0}", p);
            Console.WriteLine("La cantidad de numeros negativos es {0}", n);
            Console.ReadKey();
        }
    }
}
