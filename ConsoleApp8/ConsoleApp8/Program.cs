using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            Console.WriteLine("Ingrese numero para saber si es multiplo de 2: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            if ((A % 2) == 0)
            {
                Console.WriteLine(" es multiplo de 2");
            }
            else
            {
                Console.WriteLine("no es multiplo de 2");
            }
            Console.ReadKey();
        }
    }
}
