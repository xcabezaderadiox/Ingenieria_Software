using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a = 0;
            Console.WriteLine("Ingrese un numero");
            string numero = Console.ReadLine();
            n = int.Parse(numero);
            for (int i = 1; i < (n+1); i++)
            {
                if (n % i == 0)
                    a = a+1;

            }
            if (a != 2)
                Console.WriteLine("El numero {0} no es primo", n);
            else
                Console.WriteLine("El numero {0} es primo", n);
            Console.ReadKey();
        }
    }
}
