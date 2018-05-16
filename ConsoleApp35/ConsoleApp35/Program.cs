using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            List<int> lluvia = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la cantidad de lluvia: ");
                string mm = Console.ReadLine();
                a = int.Parse(mm);
                lluvia.Add(a);
                
            }
            //USO LAMBDA PARA OBETNER LA POSICION DEL MAYOR NUMERO
            int index = lluvia.FindIndex(r => r.Equals(lluvia.Max()));
            

            Console.WriteLine("La mayor lluvia fue de {0} mm el dia {1} de Abril", lluvia.Max(), index+1);
            Console.ReadKey();

        }
    }
}
