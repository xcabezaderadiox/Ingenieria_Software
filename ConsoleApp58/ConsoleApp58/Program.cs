using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sumador de impares!!");
            List<int> lista = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                string numero = Console.ReadLine();
                int n = int.Parse(numero);
                if (n % 2 == 1)
                    lista.Add(n);
            }
            Console.WriteLine("La sumatoria de los numeros negativos es {0}", lista.Sum());
            Console.ReadKey();
        }
    }
}
