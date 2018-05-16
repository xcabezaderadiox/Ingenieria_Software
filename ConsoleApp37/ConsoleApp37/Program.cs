using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("AVERIGUE LA MEDIA");
            List<int> numeros = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string numero = Console.ReadLine();
                a = int.Parse(numero);
                numeros.Add(a);
            }
            Console.WriteLine("La media de la lista de numeros ingresados fue {0}", numeros.Average());
            Console.ReadKey();
        }
    }
}
