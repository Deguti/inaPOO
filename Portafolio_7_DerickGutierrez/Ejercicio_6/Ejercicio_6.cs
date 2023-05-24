using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalAguinaldo = 0;
            int mesesTrabajados = 12; // Se asume que el trabajador ha trabajado todo el año
            double[] salarios = new double[12];
            double[] aguinaldos = new double[12];

            // Solicitar los 12 salarios
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Ingrese el salario mensual del mes " + (i + 1) + ":");
                salarios[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calcular los aguinaldos
            for (int i = 0; i < 12; i++)
            {
                aguinaldos[i] = (salarios[i] * 0.5) * mesesTrabajados;
            }

            // Mostrar los montos de aguinaldo correspondientes
            Console.WriteLine("Monto de aguinaldo para cada mes:");

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Mes " + (i + 1) + ": $" + aguinaldos[i]);
                totalAguinaldo = totalAguinaldo + aguinaldos[i];   //Calculo de aguinaldo total        
            }
            Console.WriteLine("El aguinaldo total es de: $" + totalAguinaldo);
            Console.ReadKey();
        }
    }
}
