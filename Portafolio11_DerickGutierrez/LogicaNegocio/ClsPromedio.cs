using System;

namespace LogicaNegocio
{
    public class ClsPromedio
    {
        #region Atributos
        private string condicion;
        private string color;
        private double promedio;
        #endregion

        #region Propiedades
        public string Condicion { get => condicion; set => condicion = value; }
        public string Color { get => color; set => color = value; }
        public double Promedio { get => promedio; set => promedio = value; }
        #endregion

        //Constructor Vacio
        public ClsPromedio() { 
        
        }

        public void CalcularPromedio(double sumaNotas, int cantNotas)
        {
            promedio = sumaNotas / cantNotas;
        }

        public void CalcularCondicion(double promedio)
        {
            if (promedio >=70)
            {
                condicion = "Aprobado";
                color = "green";
            }
            else
            {
                condicion = "Reprobado";
                color = "Red";
            }
        }

    }
}
