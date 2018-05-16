using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 0;
                List<int> lista = new List<int>();
                for (int i = 0; i < 21; i++)
                {
                    Console.WriteLine("Ingrese una nota: ");
                    string numero = Console.ReadLine();
                    a = int.Parse(numero);
                    lista.Add(a);

                }
                Console.WriteLine("La mayor nota es: {0}", lista.Max());
                Console.ReadKey();
            }
        }
    }
}
