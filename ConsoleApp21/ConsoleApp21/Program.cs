using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, a, s = 0;
            Console.WriteLine("Ingrese la base del triangulo: ");
            string Base = Console.ReadLine();
            b =  float.Parse(Base);
            Console.WriteLine("Ingrese la altura del triangulo: ");
            string Altura = Console.ReadLine();
            a = float.Parse(Altura);

            s = (b * a) / 2;
            Console.WriteLine("La superficie del triangulo es de {0}", s);
            Console.ReadKey();

        }
    }
}
