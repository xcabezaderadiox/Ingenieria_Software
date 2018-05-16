using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            List<int> multitres = new List<int>();
            List<int> multicinco = new List<int>();
            List<int> par = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                string numero = Console.ReadLine();
                n = int.Parse(numero);
                if (n % 3 == 0)
                    multitres.Add(n);
                if (n % 5 == 0)
                    multicinco.Add(n);
                if (n % 2 == 0)
                    par.Add(n);
            }
            Console.WriteLine("La sumatoria de los valores múltiplos de 3 es {0}", multitres.Sum());
            Console.WriteLine("La cantidad de valores múltiplos de 5 es {0}", multicinco.Count());
            Console.WriteLine("La suma de los numeros pares es {0}", par.Sum());
            Console.ReadKey();
        }
    }
}
