using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 20;
            int sueldo = 0;
            Console.WriteLine("Ingrese horas trabajadas: ");
            string horas = Console.ReadLine();
            int h = int.Parse(horas);
            if (h > 40)
                sueldo = ((h * s) + ((h * s) / 2));
            else
                sueldo = (h * s);
            Console.WriteLine("El sueldo del trabajador sera: {0} pesos", sueldo);
            Console.ReadKey();

        }
    }
}
