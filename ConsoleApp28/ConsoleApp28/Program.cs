using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Ingrese 20 numeros: ");
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    a = a + 1;
                    Console.WriteLine("{0} es par", i);
                }
                if (i % 2 == 1)
                {
                    b = b + 1;
                    Console.WriteLine("{0} es impar", i);
                }
            }
            Console.WriteLine("La cantidad de numeros pares es {0}", a);
            Console.WriteLine("La cantidad de numeros impares es {0}", b);
            Console.ReadKey();


        }
    }
}
