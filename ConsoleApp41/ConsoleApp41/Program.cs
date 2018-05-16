using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.WriteLine("Por favor ingrese un numero");
            string numero = Console.ReadLine();
            a = int.Parse(numero);
            while (a != 0)
            {
                if (a > 0)
                {
                    for (int i = 1; i <= a; i++)
                    {
                        b = b * i;
                    }
                    Console.WriteLine("El factorial del numero ingresado es {0}",b);
                    Console.ReadKey();
                    break;
                }
                if (a < 0)
                {
                    Console.WriteLine("Ingrese un numero mayor a cero");
                    string numero2 = Console.ReadLine();
                    a = int.Parse(numero2);
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Este numero es cero,vuelva a iniciar el programa");
                Console.ReadKey();
            }
        }
    }
}
