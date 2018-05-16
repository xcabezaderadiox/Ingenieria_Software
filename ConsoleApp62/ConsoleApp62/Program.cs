using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de la tabla a practicar: ");
            string numero = Console.ReadLine();
            int n = int.Parse(numero);
            List<int> aciertos = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el resultado de {0} x {1}", n, i);
                string resultado = Console.ReadLine();
                int r = int.Parse(resultado);
                if (r == (n * i))
                    {
                    Console.WriteLine("Correcto!");
                    aciertos.Add(r);
                    }
                else
                    Console.WriteLine("Error,el resultado era {0}",(n+i));
            }
            Console.WriteLine("Has acertado {0} multiplicaciones de 10", aciertos.Count());
            Console.ReadKey();
        }
    }
}
