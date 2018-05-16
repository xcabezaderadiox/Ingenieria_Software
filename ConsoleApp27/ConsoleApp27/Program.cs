using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Ingrese 50 numeros: ");
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 1)
                {
                    a = a + 1;
                    Console.WriteLine("{0} es impar", i);
                }
            }
            Console.WriteLine("La cantidad de numeros impares es {0}", a);
            Console.ReadKey();


        }
    }
}
