using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            double B = 0;
            Console.WriteLine("Ingrese la cantidad de manzanas a repartir: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            B = (A / 3);
            Console.WriteLine("Cada persona va a recibir una cantidad de manzana de: {0} ", B);
            Console.ReadKey();
        }
    }
}
