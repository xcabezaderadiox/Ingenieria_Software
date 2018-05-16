using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A , B = 0;
            Console.WriteLine("Ingrese numero a duplicar: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            B = A * 2;
            Console.WriteLine("Su numero ingresado multiplicado por dos es {0}", B);
        Console.ReadKey();


        }
    }
}
