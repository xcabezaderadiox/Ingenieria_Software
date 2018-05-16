using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letras = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Ingrese una letra: ");
                string b = Console.ReadLine();
                letras.Add(b);
            }
            Console.WriteLine("La mayor letra ingresada es {0}", letras.Max());
            Console.ReadKey();
        }
    }
}
