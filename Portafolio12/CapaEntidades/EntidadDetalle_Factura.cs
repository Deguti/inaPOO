using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    internal class EntidadDetalle_Factura
    {
        #region Atributos y propiedades
        private int id_factura;
        private int id_producto;
        private int cantidad;

        public int Id_factura { get => id_factura;}
        public int Id_producto { get => id_producto; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        #endregion

        #region Constructores
        public EntidadDetalle_Factura()
        {
            this.id_factura = 0;
            this.id_producto = 0;
            this.cantidad = 0;
        }

        public EntidadDetalle_Factura(int id_factura, int id_Producto, int cantidad)
        {
            this.id_factura= id_factura;
            this.id_producto= id_Producto;
            this.cantidad= cantidad;
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0} - {1}", id_factura, id_producto);
        }
    }
}
