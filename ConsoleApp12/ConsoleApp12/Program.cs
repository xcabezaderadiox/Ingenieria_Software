using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            Console.WriteLine("Ingrese dos letras: ");
            A = Console.ReadLine();
            if (A.Length == 2)
                {
                    string ordenado = new String(A.OrderBy(x => x).ToArray());
                    Console.WriteLine("Las letras ingresadas ordenadas alfabeticamente son {0}", ordenado);
                    Console.ReadKey();
                }
            else
            {
                Console.WriteLine("Solo puede ingresar dos letras");
                Console.ReadKey();
                return;
            }
        }
    }
}