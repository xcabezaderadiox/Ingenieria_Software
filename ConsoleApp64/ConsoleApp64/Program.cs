using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string caracter2 = "None";
            while (caracter2 != "#")
            {
                Console.WriteLine("Ingrese un caracter");
                string caracter = Console.ReadLine();
                caracter2 = caracter;
                if (caracter == "a" || caracter == "A" || caracter == "b" || caracter == "B" || caracter == "c" || caracter == "C" || caracter == "e" || caracter == "E" || caracter == "d" || caracter == "D" )
                    i = i + 1;
            }
            Console.WriteLine("Usted ingreso {0} vocales!", i);
            Console.ReadKey();
        }
    }
}
