using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            float A,B;
            string linea;
            Console.WriteLine("Ingrese numero a operar: ");
            linea = Console.ReadLine();
            A = int.Parse(linea);
            B = ((A + 15) / 2);
            Console.WriteLine("Su resultado es: {0}", B);
            Console.ReadKey();


        }
    }
}
