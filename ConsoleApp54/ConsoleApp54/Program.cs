using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Ingrese un 1 para iniciar el contador!");
            string comienzo = Console.ReadLine();
            c = int.Parse(comienzo);
            for (int i = 0; i < 11; i++)
            {
                c = c + i;
            }
            Console.WriteLine("El contador da como resultado: {0}", (c-1));
            Console.ReadKey();
        }
    }
}
