using System;

namespace CapaEntidades
{
    public class EntidadClientes
    {
        #region Atributos y propiedades

        private int id_cliente;
        private string nombre;
        private string telefono;
        private string descripcion;

        public int Id_cliente { get => id_cliente;}
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        #endregion

        #region constructores
        public EntidadClientes()
        {
            this.descripcion = string.Empty;
            this.id_cliente = 0;
            this.nombre = string.Empty;
            this.telefono = string.Empty;
        }

        public EntidadClientes(int id_cliente, string descripcion, string nombre, string telefono)
        {
            this.id_cliente= id_cliente;
            this.nombre = nombre;
            this.telefono = telefono;
            this.descripcion= descripcion;
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0} - {1}",id_cliente, nombre);
        }

    }

}
