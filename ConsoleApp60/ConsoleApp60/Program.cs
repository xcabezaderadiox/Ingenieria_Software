using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese un año: ");
            string año = Console.ReadLine();
            int a = int.Parse(año);
            if (a % 4 == 0 && a % 100 == 1 && a % 400 == 1)
                Console.WriteLine("El año es bisiesto");
            else
                Console.WriteLine("El año no es bisiesto");
            Console.ReadKey();
                
        }
    }
}
