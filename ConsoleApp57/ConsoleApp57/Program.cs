using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            List<int> positivos = new List<int>();
            List<int> negativos = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string numero = Console.ReadLine();
                n = int.Parse(numero);
                if (n == 0)
                {
                    Console.WriteLine("Debe ingresar un numero que no sea cero,ingrese nuevamente: ");
                    string numero2 = Console.ReadLine();
                    n = int.Parse(numero2);
                }
                if (n > 0)
                    positivos.Add(n);
                else
                    negativos.Add(n);
            }
            int m = 1;
            foreach (int item in negativos)
            {
                m = (item * m);
            }
            Console.WriteLine("La sumatoria de los numeros positivos es {0}", positivos.Sum());
            Console.WriteLine("La multiplicacion de los numeros negativos es {0}", m);
            Console.ReadKey();

        }
    }
}
