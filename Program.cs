using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10__09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cree un diccionario de notas. Solicite un nombre por teclado y verifique si existe antes de mostrar la nota.");
           Dictionary<string, double> notas = new Dictionary<string, double>();
            string nombre;
            double notas1;
            Console.WriteLine("ingrese cantidad de notas que desea ingresar: ");
            int.TryParse(Console.ReadLine(), out int lim);
            for (int i = 0; i < lim; i++)
            {
                Console.WriteLine($"Ingrese  nombre NO.{i + 1} de {lim}");
                nombre= Console.ReadLine();
                if (estudiante.ContainsKey(nombre))
                {
                    Console.WriteLine("nombre ya ingresado");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    estudiante.Add(Id, nombre);

                }

            }
            bool validar = false;
            while (validar != true)
            {


                Console.WriteLine("ingrese ID de estudiante que desea elimar");
                int.TryParse(Console.ReadLine(), out Id);
                if (estudiante.ContainsKey(Id))
                {
                    estudiante.Remove(Id);
                    validar = true;
                }
                else
                {
                    Console.WriteLine("ID invalido");
                }
            }
            foreach (var item in estudiante)
            {
                Console.WriteLine("prodcuto Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
