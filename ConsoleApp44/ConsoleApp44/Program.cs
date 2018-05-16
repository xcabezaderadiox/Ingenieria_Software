using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            List<int> lista = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero {0} de 70 : ",i+1);
                string numero = Console.ReadLine();
                a = int.Parse(numero);
                if (a % 2 == 0)
                    lista.Add(a);
            }
            Console.WriteLine("El promedio de la lista ingresada es {0}", lista.Average());
            Console.ReadKey();
            
        }
    }
}
