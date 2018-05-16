using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            //VECTORES
            //int[] temperatura = new int[30];
            //temperatura[0] = 27;
            //temperatura[1] = 24;
            //temperatura[2] = 31;
            //System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

            //LISTAS
            float aux = 0;
            List<float> temperatura = new List<float>();
            //temperatura.Add(21.1F);
            //temperatura.Add(22.8F);
            for (int i = 0; i < 3; i++)
            {
                aux = LeerNumero();
                temperatura.Add(aux);
            }
            Console.Clear();
            for (int i = 0; i < temperatura.Count ; i++)
                Console.WriteLine(temperatura[i].ToString());

            Console.Clear();
            temperatura.Max();
            //float max = float.MiValue;
            //foreach (max item in temperatura)
            //{
            //    if (item > max)
            //        max = item;
            //}

            Console.WriteLine("La temperatura maxima es: {0}", temperatura.Max());
            Console.ReadKey();

        }
        //uso metodo creado arriba con la seleccion y lamparita doble click se crea solo 
        //se ingresa numero lo lee y escribe en pantalla
        private static float LeerNumero()
        {
            float aux;
            Console.Write("Ingrese temperatura: ");
            string palabra = Console.ReadLine();
            while (!float.TryParse(palabra, out aux))
            {
                Console.WriteLine("Vuelva a ingresar: ");
                Console.ReadLine();
            }

            return aux;

        }

    }
}