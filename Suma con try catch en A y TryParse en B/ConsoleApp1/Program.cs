﻿using System;
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
            try
            {
                A = int.Parse(linea);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un error,ingrese solo numero por favor");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Ingrese otro numero: ");
            linea = Console.ReadLine();
            if (!int.TryParse(linea,out B))
            {
                Console.WriteLine("ERROR:Solo ingrese numero");
                Console.ReadKey();
                return;
            }
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