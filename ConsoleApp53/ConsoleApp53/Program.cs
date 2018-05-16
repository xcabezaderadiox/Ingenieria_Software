using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            int s,e = 0;
            double al = 0;
            List<double> listamm = new List<double>();
            List<double> listahm = new List<double>();
            List<double> listaha = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese 1 si es mujer o 2 si es hombre: ");
                string sexo =Console.ReadLine();
                s = int.Parse(sexo);
                if (s == 1)
                {
                    Console.WriteLine("Ingrese su edad: ");
                    string edad = Console.ReadLine();
                    e = int.Parse(edad);
                    if (e > 25)
                    {
                        listamm.Add(e);
                    }
                }
                if (s==2)
                {
                    Console.WriteLine("Ingrese su edad: ");
                    string edad = Console.ReadLine();
                    e = int.Parse(edad);
                    if (e < 18)
                    {
                        listahm.Add(e);
                    }
                    else
                    {
                        Console.WriteLine("Indique su altura: ");
                        string altura = Console.ReadLine();
                        al = double.Parse(altura);
                        if (al > 1.70)
                        {
                            listaha.Add(al);
                        }

                    }
                }
            }
            double pmm = 0;
            double a = listamm.Count();
            pmm = ((a / 5) * 100);
            Console.WriteLine("El porcentaje de mujer mayor de 25 años es {0}%",pmm);
            Console.WriteLine("La cantidad de hombres menores de 18 años es {0}", listahm.Count());
            double pha = 0;
            double b = listaha.Count();
            pha = ((b / 5) * 100);
            Console.WriteLine("El porcentaje de hombres mayors de 18 años y de altura mayor a 1.70 es {0}%", pha);
            Console.ReadKey();
        }
    }
}
