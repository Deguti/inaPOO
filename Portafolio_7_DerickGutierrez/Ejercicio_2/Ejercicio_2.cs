using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, ventas, comision, salarioBruto;

            Console.WriteLine("Ingrese el salario base del empleado");
            salarioBase= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el monto total de ventas realizadas en el mes");
            ventas= Convert.ToDouble(Console.ReadLine());

            //Calcular la comision(10% de las ventas)
            comision = ventas * 0.10;

            //Calcular salario bruto(Salario base + comision)
            salarioBruto = salarioBase + comision;

            Console.WriteLine("El salario bruto del empleado es : $" + salarioBruto);
            Console.ReadKey();
        }
    }
}
