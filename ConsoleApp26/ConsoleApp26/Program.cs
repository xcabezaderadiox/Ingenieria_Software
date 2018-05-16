using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Ingrese 100 numeros: ");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    a = a + 1;
                    Console.WriteLine("{0} es par",i);
                }
            }
            Console.WriteLine("La cantidad de numeros pares es {0}", a);
            Console.ReadKey();


        }
    }
}
