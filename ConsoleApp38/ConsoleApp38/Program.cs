using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Ingrese nota del examen: ");
                string nota = Console.ReadLine();
                n = int.Parse(nota);
                if (n == 0)
                {
                    Console.WriteLine("Ingreso un cero");
                    Console.ReadKey();
                    break;
                }
                if (n < 5)
                    Console.WriteLine("EN SUSPENSO");
                if (n == 5 || n == 6)
                    Console.WriteLine("APROBADO");
                if (n == 7 || n == 8)
                    Console.WriteLine("NOTABLE!");
                if (n == 9)
                    Console.WriteLine("SOBRESALIENTE!!");
                if (n == 10)
                    Console.WriteLine("MATRICULA DE HONOR!!!!!");
            } while (n != 0);
        }
    }
}
