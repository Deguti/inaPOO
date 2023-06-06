using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _02_CapaLogicaNegocio;
using CapaEntidades;

namespace _01_CapaPresentracion
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            AdministracionClientes administracionClientes = new AdministracionClientes();
            administracionClientes.Show();
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            AdministracionClientes administracionClientes = new AdministracionClientes();
            administracionClientes.Show();
        }

        private void mnuFacturacion_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            facturacion.Show();
        }

    }
}
