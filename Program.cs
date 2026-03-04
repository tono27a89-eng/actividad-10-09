using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
                if (notas.ContainsKey(nombre))
                {
                    Console.WriteLine("nombre ya ingresado");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese nota:");
                    double.TryParse(Console.ReadLine(), out notas1);
                    notas.Add(nombre, notas1);

                }
               

            }
            bool validar = false;
            while (validar != true)
            {
                Console.WriteLine("ingrese nombre de nota que desea ver");
                nombre = Console.ReadLine();
                if (notas.ContainsKey(nombre))
                {
                    Console.WriteLine("la nota es" + notas[nombre]);
                    validar = true;
                }
                else
                {
                    Console.WriteLine("ingrese nombre valido");
                }
            }

        }
    }
}
