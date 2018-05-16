using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            Console.WriteLine("Ingrese numero para saber si es multiplo de 5: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            if ((A % 5) == 0)
            {
                Console.WriteLine(" es multiplo de 5");
            }
            else
            {
                Console.WriteLine("no es multiplo de 5");
            }
            Console.ReadKey();
        }
    }
}
