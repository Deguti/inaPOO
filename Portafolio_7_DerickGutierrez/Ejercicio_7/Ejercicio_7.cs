using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double anchoTerreno;
            double longitudTerreno;
            double distanciaEntrePostes = 2.0;
            int cantidadPostes;

            Console.WriteLine("Ingrese el ancho del terreno:");
            anchoTerreno = Convert.ToDouble(Console.ReadLine());

            // Calcular la longitud del terreno
            longitudTerreno = anchoTerreno * 2.0;

            // Calcular la cantidad de postes necesarios
            cantidadPostes = (int)Math.Ceiling(longitudTerreno / distanciaEntrePostes);

            Console.WriteLine("La cantidad de postes necesarios para cercar el terreno es: " + cantidadPostes);
        }
    }
}
