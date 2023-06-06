using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    internal class EntidadProductos
    {
        #region Atributos y propiedades
        private int id_producto;
        private string descripcion;
        private double precio_venta;
        private double precio_compra;
        private string grabado;

        public int Id_producto { get => id_producto; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
        public double Precio_compra { get => precio_compra; set => precio_compra = value; }
        public string Grabado { get => grabado; set => grabado = value; }
        #endregion

        #region Constructores
        public EntidadProductos()
        {
            this.id_producto = 0;
            this.descripcion = string.Empty;
            this.precio_venta = 0;
            this.precio_compra = 0;
        }

        public EntidadProductos(int id_producto, string descripcion, double precio_venta, double precio_compra, string grabado)
        {
            this.id_producto = id_producto;
            this.Descripcion = descripcion;
            this.Precio_venta = precio_venta;
            this.Precio_compra = precio_compra;
            this.Grabado = grabado;
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", id_producto, descripcion,Precio_venta,Precio_compra);
        }
    }
}
