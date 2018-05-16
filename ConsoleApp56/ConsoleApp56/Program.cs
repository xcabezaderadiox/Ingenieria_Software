using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sumador de multiplos de 2!!");
            Console.ReadKey();
            List<int> lista = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Multiplo de 2: {0}", i);
                    lista.Add(i);
                }
            }
            Console.WriteLine("La sumatoria total de los multiplos es {0}", lista.Sum());
            Console.ReadKey();
        }
    }
}
