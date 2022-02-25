using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.WriteLine("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Te llamas " + nombre + " y tienes: " + edad + " años.");
            Console.WriteLine("Presione cualquier tecla para finalizar ");
            Console.ReadKey();

        }
    }
}
