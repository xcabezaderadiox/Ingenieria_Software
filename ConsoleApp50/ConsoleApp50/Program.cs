using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 1;
            List<double> lista = new List<double>();
            while (n > 0)
            {
                Console.WriteLine("Ingrese un numero:");
                string numero = Console.ReadLine();
                n = double.Parse(numero);
                if (n > 0)
                    lista.Add(n);
            }
            Console.WriteLine("Se corta el ingreso de numeros al ser el ingresado menor a 0");
            Console.WriteLine("El valor menor ingresado fue {0}", lista.Min());
            Console.WriteLine("El valor maximo ingresado fue {0}", lista.Max());
            Console.ReadKey();
        }
    }
}
