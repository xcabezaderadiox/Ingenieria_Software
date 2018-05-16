using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b = 0;
            Console.WriteLine("Por favor ingrese un numero");
            string numero = Console.ReadLine();
            a = int.Parse(numero);
            while (a != 0)
            {
                b = a * a;
                Console.WriteLine("El cuadrado del numero ingresado es {0}", b);
                Console.ReadKey();
                break;
            }
            if (a == 0)
            {
                Console.WriteLine("ERROR,el Número debe ser mayor que cero");
                Console.ReadKey();
            }
        }
    }
}
