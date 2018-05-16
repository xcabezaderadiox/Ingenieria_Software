using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> livianos = new List<int>();
            List<int> pesados = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese su peso: ");
                string peso = Console.ReadLine();
                int p = int.Parse(peso);
                if (p > 80)
                    pesados.Add(p);
                else
                    livianos.Add(p);
            }
            Console.WriteLine("La cantidad de personas que pesan mas de 80 kilos es {0}", pesados.Count());
            Console.WriteLine("La cantidad de personas que pesan menos de 80 kilos es {0}", livianos.Count());
            Console.ReadKey();
        }
    }
}
