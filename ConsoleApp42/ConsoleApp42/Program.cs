using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Ingrese un numero");
            string numero = Console.ReadLine();
            a = int.Parse(numero);
            List<int> lista = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    lista.Add(i);
            }
            foreach (var item in lista)
            {
                Console.WriteLine("Los divisores del numero ingresado son {0}", item);
                Console.ReadKey();
            }
            
        }
    }
}
