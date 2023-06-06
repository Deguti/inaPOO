using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    internal class EntidadEncabezado_Factura
    {
        #region Atributos y propiedades
        private int id_factura;
        private int id_cliente;
        private string fecha;
        private double subTotal;
        private double impuesto;
        private double descuento;
        #endregion

        #region Constructores
        public EntidadEncabezado_Factura()
        {
            this.id_factura = 0;
            this.id_cliente = 0;
            this.fecha = string.Empty;
            this.subTotal = 0;
            this.impuesto = 0;
            this.descuento = 0;
        }
        public EntidadEncabezado_Factura(int id_factura, int id_cliente, string fecha, double subTotal, double impuesto, double descuento)
        {
            this.id_factura = id_factura;
            this.id_cliente = id_cliente;
            this.fecha = fecha;
            this.subTotal = subTotal;
            this.impuesto = impuesto;
            this.descuento = descuento;
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0} - {1} -{2}", id_factura, id_cliente, fecha);
        }
    }
}
