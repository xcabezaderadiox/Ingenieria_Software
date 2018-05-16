using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B = 0;
            Console.WriteLine("Ingrese su edad actual: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            B = A + 23;
            Console.WriteLine("Su edad dentro de 23 años sera de  {0}", B);
            Console.ReadKey();
        }
        
    }
}
