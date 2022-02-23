using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vala = 10;
            int valb = 10;
            int valc = 7;
            float area= (vala*valb)/2;
            Console.WriteLine("El AREA del triangulo es: " + area);
            Console.WriteLine("Presiona cualquier tecla para finalizar ");
            Console.ReadKey();
        }
    }
}
