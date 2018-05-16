using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> notas = new List<int>();
            List<string> sexo = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la nota del alumno: ");
                string nota = Console.ReadLine();
                int a = int.Parse(nota);
                notas.Add(a);
                Console.WriteLine("Ingrese H si es hombre o M si es mujer: ");
                string sex = Console.ReadLine();
                sexo.Add(sex);
            }
            //USO LAMBDA PARA OBETNER LA POSICION DEL MAYOR NUMERO
            int index = notas.FindIndex(r => r.Equals(notas.Max()));
            string genero = sexo[index];
            
            Console.WriteLine("La nota mayor es {0} y su sexo es {1}", notas.Max(),genero);
            Console.ReadKey();

        }
    }
}
