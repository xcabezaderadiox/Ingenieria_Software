using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero,se llamara NUM1: ");
            string num1 = Console.ReadLine();
            int n1 = int.Parse(num1);
            Console.WriteLine("Ingrese otro numero,se llamara NUM2: ");
            string num2 = Console.ReadLine();
            int n2 = int.Parse(num2);
            int aux = n1;
            int aux2 = n2;
            n1 = aux2;
            n2 = aux;
            Console.WriteLine("El NUM1 ahora es {0} y el NUM2 ahora es {1}", n1, n2);
            Console.ReadKey();


        }
    }
}
