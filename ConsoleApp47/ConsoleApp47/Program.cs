using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, b = 0;
            Console.WriteLine("Ingrese la base");
            string Base = Console.ReadLine();
            b = int.Parse(Base);
            Console.WriteLine("Ingrese la exponencial");
            string Exponencial = Console.ReadLine();
            e = int.Parse(Exponencial);
            Console.WriteLine("Los datos ingresados son: {0} elevado a la potencia {1}", b, e);
            Console.WriteLine("Su resultado es {0}", Math.Pow(b, e));
            Console.ReadKey();
        }
    }
}
