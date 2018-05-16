using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            double l, a, r = 0;
            double pi = 3.14;
            Console.WriteLine("Ingrese el radio del circulo: ");
            string radio = Console.ReadLine();
            r = float.Parse(radio);

            l = (r * pi * 2);
            a = (pi * r);
            Console.WriteLine("La longitud del circulo es de {0}: ",l);
            //Math.Pow eleva a la potencia solicitada en el segundo argumento
            Console.WriteLine("El area del circulo es de {0}: ", Math.Pow(a,2));
            Console.ReadKey();

        }
    }
}
