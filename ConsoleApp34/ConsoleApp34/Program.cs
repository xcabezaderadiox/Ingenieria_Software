using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            Console.WriteLine("SISTEMA METEOROLOGICO NACIONAL");
            List<int> temperatura = new List<int>();
            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine("Ingrese temperatura");
                string temp = Console.ReadLine();
                t = int.Parse(temp);
                temperatura.Add(t);
            }
            int index = temperatura.FindIndex(r => r.Equals(temperatura.Min()));
            int dia = temperatura[index];
            Console.WriteLine("La menor temperatura registrada fue de {0} el dia {1} de Abril", temperatura.Min(),index+1);
            Console.ReadKey();
        }
    }
}
