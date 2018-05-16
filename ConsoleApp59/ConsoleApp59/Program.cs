using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la intensidad utilizada: ");
            string intensidad = Console.ReadLine();
            int i = int.Parse(intensidad);
            Console.WriteLine("Ingrese la resistencia utilizada: ");
            string resistencia = Console.ReadLine();
            int r = int.Parse(resistencia);
            if (r <= 0 || r > 10000)
            {
                Console.WriteLine("La resistencia no puede valer cero ohms ni ser mayor a 10000 ohms,ingresela nuevamente: ");
                string resistencia2 = Console.ReadLine();
                r = int.Parse(resistencia2);
            }
            int v = i * r;
            Console.WriteLine("La diferencia de potencial obtenida es: {0} volts", v);
            Console.ReadKey();
        }
    }
}
