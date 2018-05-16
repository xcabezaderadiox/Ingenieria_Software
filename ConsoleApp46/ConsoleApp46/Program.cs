using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            List<int> positivo = new List<int>();
            List<int> negativo = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string numero2 = Console.ReadLine();
                a = int.Parse(numero2);
                if (a < 0)
                    negativo.Add(a);
                if (a > 0)
                    positivo.Add(a);
            }
            Console.WriteLine("La cantidad de numeros negativos ingresados es {0}", negativo.Count());
            Console.WriteLine("La cantidad de numeros positivos ingresados es {0}", positivo.Count());
            Console.ReadKey();
        }
    }
}
