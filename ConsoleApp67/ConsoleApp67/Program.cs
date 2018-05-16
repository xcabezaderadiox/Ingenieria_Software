using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su sueldo:");
            string sueldo1 = Console.ReadLine();
            double s = double.Parse(sueldo1);
            double descuento,sueldo = 0;
            if (s <= 1000)
            {
                descuento = (s * 0.1);
                sueldo = (s - descuento);
                Console.WriteLine("Su descuento es de {0}$", descuento);
                Console.WriteLine("Su sueldo final es de {0}$", sueldo);
            }
            if (s > 1000 && s < 2000)
            {
                descuento = (s * 0.05);
                sueldo = (s - descuento);
                Console.WriteLine("Su descuento es de {0}$", descuento);
                Console.WriteLine("Su sueldo final es de {0}$", sueldo);
            }
            if (s >= 2000)
            {
                descuento = (s * 0.03);
                sueldo = (s - descuento);
                Console.WriteLine("Su descuento es de {0}$", descuento);
                Console.WriteLine("Su sueldo final es de {0}$", sueldo);
            }
            Console.ReadKey();
            

        }
    }
}
