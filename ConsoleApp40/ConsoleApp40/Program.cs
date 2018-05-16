using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Ingrese su nota: ");
            string nota = Console.ReadLine();
            n = int.Parse(nota);
            if (n == 19 || n == 20)
            {
                Console.WriteLine("Su nota es una A");
            }
            if(n == 16 || n == 17 || n == 18)
            {
                Console.WriteLine("Su nota es una B");
            }
            if (n == 13 || n == 14 || n == 15)
            {
                Console.WriteLine("Su nota es una C");
            }
            if (n == 11 || n == 10 || n == 12)
            {
                Console.WriteLine("Su nota es una D");
            }
            if (n > 1 && n < 9)
            {
                Console.WriteLine("Su nota es una E");
            }
            else
                Console.WriteLine("La nota debe ser entre 1 y 20 por favor ingrese nuevamente");
            Console.ReadKey();
        }
    }
}
