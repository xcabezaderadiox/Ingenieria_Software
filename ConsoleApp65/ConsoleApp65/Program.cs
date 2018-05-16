using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cuantos numeros vamos a usar: ");
            string numeros = Console.ReadLine();
            int n = int.Parse(numeros);
            List<int> lista = new List<int>();
            int i = 0;
            while (i != n)
            {
                Console.WriteLine("Ingrese un numero: ");
                string ingreso = Console.ReadLine();
                int a = int.Parse(ingreso);
                lista.Add(a);
                i = i + 1;
            }
            Console.WriteLine("El menor numero ingresado es {0}", lista.Min());
            Console.WriteLine("El mayor numero ingresado es {0}", lista.Max());
            Console.WriteLine("El promedio de los numeros ingresados es {0}", lista.Average());
            Console.ReadKey();           
        }
    }
}
