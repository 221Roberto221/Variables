using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vala = 10;
            int valb = 10;
            int valc = 7;
            int perimetro = vala + valb + valc;
            Console.WriteLine("El PERIMETRO del triangulo es: " + perimetro);
            Console.WriteLine("Presiona cualquier tecla para finalizar ");
            Console.ReadKey();

        }
    }
}
