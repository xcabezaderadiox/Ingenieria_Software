﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            Console.WriteLine("Ingrese numero para saber si es par o impar: ");
            string linea = Console.ReadLine();
            A = int.Parse(linea);
            if ((A % 2) == 0)
            {
                Console.WriteLine(" es par");
            }
            else
            {
                Console.WriteLine(" es impar");
            }
            Console.ReadKey();
        }
    }
}