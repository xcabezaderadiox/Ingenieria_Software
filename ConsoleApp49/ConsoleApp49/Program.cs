using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int f = 0;
            int n = 0;
            Console.WriteLine("Ingrese comienzo del extremo: ");
            string comienzo = Console.ReadLine();
            c = int.Parse(comienzo);
            Console.WriteLine("Ingrese el extremo final: ");
            string final = Console.ReadLine();
            f = int.Parse(final);
            List<int> lista = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                string numero = Console.ReadLine();
                n = int.Parse(numero);
                if (n > c && n < f)
                    lista.Add(n);
            }
            Console.WriteLine("La cantidad de numeros ingresados en el intervalo es {0}", lista.Count());
            Console.ReadKey();
        }
    }
}
