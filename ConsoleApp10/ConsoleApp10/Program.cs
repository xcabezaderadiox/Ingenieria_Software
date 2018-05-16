using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B = 0;
            Console.WriteLine("Ingrese el primer numero para saber si es divisible por 3: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo numero para saber si es divisible por 3: ");
            string linea2 = Console.ReadLine();
            B = int.Parse(linea2);
            if (((A % 3) == 0) & ((B % 3) == 0))
            {
                Console.WriteLine(" Ambos son divisibles por 3");
            }
            if (((A % 3) == 0) & ((B % 3) != 0))
            {
                Console.WriteLine(" El primer numero es divisible por 3");
            }
            if (((A % 3) != 0) & ((B % 3) == 0))
            {
                Console.WriteLine(" El segundo numero es divisible por 3");
            }
            else
            {
                Console.WriteLine("Ninguno es divisible por 3");
            }


            Console.ReadKey();
        }
    }
}
