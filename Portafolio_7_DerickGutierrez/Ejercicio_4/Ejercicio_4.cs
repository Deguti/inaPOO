using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundos, horas, minutos, segundosRestantes;

            Console.WriteLine("Ingrese la cantidad de segundos:");
            segundos = Convert.ToInt32(Console.ReadLine());

            // Calcular horas
            horas = segundos / 3600;
            segundosRestantes = segundos % 3600;

            // Calcular minutos
            minutos = segundosRestantes / 60;
            segundosRestantes = segundosRestantes % 60;

            // Mostrar el resultado
            Console.WriteLine("Horas: " + horas);
            Console.WriteLine("Minutos: " + minutos);
            Console.WriteLine("Segundos: " + segundosRestantes);
            Console.ReadKey();
        }
    }
}
