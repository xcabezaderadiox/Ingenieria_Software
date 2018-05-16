using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int a = 0;
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();
            List<int> lista3 = new List<int>();
            do
            {
                Console.WriteLine("Ingrese numero: ");
                string nota = Console.ReadLine();
                n = int.Parse(nota);
                if (n == 0)
                {
                    Console.WriteLine("Ingreso un cero");
                    Console.ReadKey();
                    break;
                }
                if (n > 50 && n < 75)
                { 
                    lista1.Add(n);
                }
                if (n > 80)
                {
                    lista2.Add(n);
                }
                if (n < 30)
                {
                    lista3.Add(n);
                }
            } while (n != 0);
            Console.WriteLine("La cantidad de numeros entre 50 y 75 son {0}", lista1.Count());
            Console.WriteLine("La cantidad de numeros mayores a 80 son {0}", lista2.Count());
            Console.WriteLine("La cantidad de numeros menores a 30 son {0}", lista3.Count());
            Console.ReadKey();
        }
    }
}
