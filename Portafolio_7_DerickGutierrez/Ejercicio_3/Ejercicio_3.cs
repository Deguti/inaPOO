using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos, totalSegundos;

            Console.WriteLine("Ingrese la cantidad de horas");
            horas=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de minutos");
            minutos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de segundos");
            segundos = Convert.ToInt32(Console.ReadLine());

            //Calcular el total de segundos
            totalSegundos = (horas * 3600) + (minutos * 60) + segundos;

            Console.WriteLine("el total de segundos es: " + totalSegundos);
            Console.ReadKey();
        }
    }
}
