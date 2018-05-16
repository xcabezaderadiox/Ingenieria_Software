using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            int c = 0;
            while (c < 5)
            {
                int a = 0;
                int n = 0;
                Console.WriteLine("Ingrese un numero");
                string numero = Console.ReadLine();
                n = int.Parse(numero);
                for (int i = 1; i < (n + 1); i++)
                {
                    if (n % i == 0)
                        a = a + 1;
                }
                if (a != 2)
                    Console.WriteLine("El numero {0} no es primo", n);
                else
                {
                    lista.Add(n);
                    Console.WriteLine("El numero {0} es primo", n);
                    c = c + 1;
                }
            }
            foreach (int item in lista)
                Console.WriteLine("Los numeros primos ingresados fueron {0}", item);
            Console.ReadKey();
        }
    }
}
