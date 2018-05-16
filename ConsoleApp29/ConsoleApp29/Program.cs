using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 0;
                List<int> lista = new List<int>();
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine("Ingrese un numero: ");
                    string numero = Console.ReadLine();
                    a = int.Parse(numero);
                    lista.Add(a);

                }
                Console.WriteLine("El mayor numero es: {0}",lista.Max());
                Console.WriteLine("La ubicacion del numero mayor es: {0}", lista.IndexOf(lista.Max()));
                Console.ReadKey();
            }
        }
    }
}
