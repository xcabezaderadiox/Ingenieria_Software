using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C = 0;
            Console.WriteLine("Ingrese un numero: ");
            String linea = Console.ReadLine(); //Leo entrada como string
            A = int.Parse(linea);
            Console.WriteLine("Ingrese otro numero: ");
            linea = Console.ReadLine();
            B = int.Parse(linea);
            if (A == B)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                C = A + B;
            Console.WriteLine("La suma es {0}", C);
            }
        Console.ReadKey();
        }

    }

}

