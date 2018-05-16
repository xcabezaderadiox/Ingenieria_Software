using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i != 10)
            { 
                Console.WriteLine("Ingrese un caracter: ");
                string a = Console.ReadLine();
                if (a == "a" || a == "A")
                    i = i + 1;
                else
                    Console.WriteLine("No es una letra A");
            }
            Console.WriteLine("Ingreso 10 caracteres A!!!");
            Console.ReadKey();

        }
    }
}
