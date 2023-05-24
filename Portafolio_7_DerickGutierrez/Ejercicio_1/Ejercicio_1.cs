using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double frentePies, fondoPies, areaMetrosCuadrados;

            Console.WriteLine("Ingrese el frente del terreno en pies:");
            frentePies = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el fondo del terreno en pies:");
            fondoPies = Convert.ToDouble(Console.ReadLine());

            // Convertir los valores de pies a metros
            double frenteMetros = ConvertirPiesAMetros(frentePies);
            double fondoMetros = ConvertirPiesAMetros(fondoPies);

            // Calcular el área en metros cuadrados
            areaMetrosCuadrados = frenteMetros * fondoMetros;

            Console.WriteLine("El área del terreno es: " + areaMetrosCuadrados + " m²");
            Console.ReadKey();
        }

        static double ConvertirPiesAMetros(double pies)
        {
            const double conversion = 0.3048; // 1 pie = 0.3048 metros
            return pies * conversion;
        }
    }
}

