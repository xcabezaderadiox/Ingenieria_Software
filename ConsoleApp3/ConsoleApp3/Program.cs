using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            double B = 0;
            Console.WriteLine("Ingrese monto de compra sin impuestos: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            B = A + (A * 0.21);
            Console.WriteLine("El valor de compra final mas IVA es de {0}", B );
            Console.ReadKey();
        }
    }
}
