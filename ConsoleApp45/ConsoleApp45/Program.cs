using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            List<int> lista = new List<int>();
            Console.WriteLine("Por favor ingrese un numero:");
            string numero = Console.ReadLine();
            a = int.Parse(numero);
            while (a != 0)
            {
                if (a < 0)
                {
                    Console.WriteLine("Ingrese otro numero,debe ser mayor a cero");
                    string numero3 = Console.ReadLine();
                    a = int.Parse(numero3);
                }
                lista.Add(a);
                Console.WriteLine("Ingrese otro numero");
                string numero2 = Console.ReadLine();
                a = int.Parse(numero2);

            }
            if (a == 0)
            {
                Console.WriteLine("El promedio de los numeros positivos ingresados es {0}",lista.Average());
                Console.WriteLine("Ingreso un cero se cierra el programa");
                Console.ReadKey();
            }
            
        }
    }
}
