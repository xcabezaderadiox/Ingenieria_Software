using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b = 0;
            Console.WriteLine("Ingrese el numero a saber su tabla de multiplicar: ");
            string numero = Console.ReadLine();
            a = int.Parse(numero);
            for (int i = 0; i < 11; i++)
            {
                b = (a * i);
                Console.WriteLine("Tabla multiplicar del {0}: x{1} es {2}",a,i,b);
            }
            Console.ReadKey();
        }
    }
}
