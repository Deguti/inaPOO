using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double megabytes;

            Console.WriteLine("Ingrese la cantidad de megabytes:");
            megabytes = Convert.ToDouble(Console.ReadLine());

            // Calcular las conversiones
                                                        //"8e+6" significa "8 multiplicado por 10 elevado
                                                        // a la potencia de 6 es una forma abreviada de representar 8000000
            double bits = megabytes * 8e+6;             // 1 MB = 8e+6 bits,
            double bytes = megabytes * 1e+6;            // 1 MB = 1e+6 bytes
            double kilobytes = megabytes * 1000;        // 1 MB = 1000 KB
            double gigabytes = megabytes / 1000;        // 1 MB = 0.001 GB

            // Mostrar el resultado
            Console.WriteLine("Equivalencias:");
            Console.WriteLine("Bits: " + bits);
            Console.WriteLine("Bytes: " + bytes);
            Console.WriteLine("Kilobytes: " + kilobytes);
            Console.WriteLine("Gigabytes: " + gigabytes);
            Console.ReadKey();
        }
    }
}
