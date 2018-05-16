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
            float t = 0;
            Console.WriteLine("SISTEMA METEOROLOGICO NACIONAL");
            List<float> temperatura = new List<float>();
            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine("Ingrese temperatura");
                string temp = Console.ReadLine();
                t = float.Parse(temp);
                temperatura.Add(t);
            }
            Console.WriteLine("La mayor temperatura registrada fue de {0}", temperatura.Max());
            Console.WriteLine("La menor temperatura registrada fue de {0}", temperatura.Min());
            Console.ReadKey();
        }
    }
}
