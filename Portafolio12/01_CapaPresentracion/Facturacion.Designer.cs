namespace _01_CapaPresentracion
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.lblCodFactura = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtCodFactura = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalirFactura = new System.Windows.Forms.Button();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.btnBuscarFcatura = new System.Windows.Forms.Button();
            this.CodigoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodFactura
            // 
            this.lblCodFactura.AutoSize = true;
            this.lblCodFactura.Location = new System.Drawing.Point(172, 25);
            this.lblCodFactura.Name = "lblCodFactura";
            this.lblCodFactura.Size = new System.Drawing.Size(104, 15);
            this.lblCodFactura.TabIndex = 0;
            this.lblCodFactura.Text = "Codigo de Factura";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(305, 25);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(102, 15);
            this.lblCodCliente.TabIndex = 1;
            this.lblCodCliente.Text = "Codigo de Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(569, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(29, 288);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(56, 15);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(207, 287);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(57, 15);
            this.lblImpuesto.TabIndex = 4;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(383, 287);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(63, 15);
            this.lblDescuento.TabIndex = 5;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(571, 287);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(33, 15);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(438, 25);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(27, 25);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(114, 15);
            this.lblCodProducto.TabIndex = 8;
            this.lblCodProducto.Text = "Codigo de Producto";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(27, 52);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(114, 23);
            this.txtCodProducto.TabIndex = 9;
            // 
            // txtCodFactura
            // 
            this.txtCodFactura.Location = new System.Drawing.Point(172, 52);
            this.txtCodFactura.Name = "txtCodFactura";
            this.txtCodFactura.Size = new System.Drawing.Size(104, 23);
            this.txtCodFactura.TabIndex = 10;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(307, 50);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 23);
            this.txtCodCliente.TabIndex = 11;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(569, 50);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 23);
            this.txtFecha.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(438, 50);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(91, 288);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(266, 288);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(452, 287);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 16;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(610, 288);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 23);
            this.textBox9.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoFactura,
            this.codigoCliente,
            this.codigoProducto,
            this.fecha,
            this.cantidad,
            this.subtotal,
            this.impuesto,
            this.descuento});
            this.dataGridView1.Location = new System.Drawing.Point(27, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(681, 201);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnSalirFactura
            // 
            this.btnSalirFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirFactura.Image")));
            this.btnSalirFactura.Location = new System.Drawing.Point(588, 342);
            this.btnSalirFactura.Name = "btnSalirFactura";
            this.btnSalirFactura.Size = new System.Drawing.Size(119, 78);
            this.btnSalirFactura.TabIndex = 32;
            this.btnSalirFactura.Text = "&Salir";
            this.btnSalirFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalirFactura.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarFactura.Image")));
            this.btnEliminarFactura.Location = new System.Drawing.Point(402, 342);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(119, 78);
            this.btnEliminarFactura.TabIndex = 31;
            this.btnEliminarFactura.Text = "&Eliminar";
            this.btnEliminarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarFactura.UseVisualStyleBackColor = true;
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarFactura.Image")));
            this.btnGuardarFactura.Location = new System.Drawing.Point(278, 342);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(119, 78);
            this.btnGuardarFactura.TabIndex = 30;
            this.btnGuardarFactura.Text = "&Guardar";
            this.btnGuardarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarFactura.UseVisualStyleBackColor = true;
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaFactura.Image")));
            this.btnNuevaFactura.Location = new System.Drawing.Point(154, 342);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(119, 78);
            this.btnNuevaFactura.TabIndex = 29;
            this.btnNuevaFactura.Text = "&Nueva Factura";
            this.btnNuevaFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFcatura
            // 
            this.btnBuscarFcatura.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFcatura.Image")));
            this.btnBuscarFcatura.Location = new System.Drawing.Point(29, 342);
            this.btnBuscarFcatura.Name = "btnBuscarFcatura";
            this.btnBuscarFcatura.Size = new System.Drawing.Size(119, 78);
            this.btnBuscarFcatura.TabIndex = 28;
            this.btnBuscarFcatura.Text = "&Buscar";
            this.btnBuscarFcatura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarFcatura.UseVisualStyleBackColor = true;
            // 
            // CodigoFactura
            // 
            this.CodigoFactura.DataPropertyName = "ID_FACTURA";
            this.CodigoFactura.HeaderText = "Cod. de Factura";
            this.CodigoFactura.Name = "CodigoFactura";
            this.CodigoFactura.Width = 120;
            // 
            // codigoCliente
            // 
            this.codigoCliente.DataPropertyName = "ID_CLIENTE";
            this.codigoCliente.HeaderText = "Cod. de Cliente";
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.Width = 120;
            // 
            // codigoProducto
            // 
            this.codigoProducto.DataPropertyName = "ID_PRODUCTO";
            this.codigoProducto.HeaderText = "Cod. de Producto";
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.Width = 125;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "FECHA";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "CANTIDAD";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "SUBTOTAL";
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            // 
            // impuesto
            // 
            this.impuesto.DataPropertyName = "IMPUESTO";
            this.impuesto.HeaderText = "Impuesto";
            this.impuesto.Name = "impuesto";
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "DESCUENTO";
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirFactura);
            this.Controls.Add(this.btnEliminarFactura);
            this.Controls.Add(this.btnGuardarFactura);
            this.Controls.Add(this.btnNuevaFactura);
            this.Controls.Add(this.btnBuscarFcatura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.txtCodFactura);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.lblCodProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.lblCodFactura);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodFactura;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtCodFactura;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalirFactura;
        private System.Windows.Forms.Button btnEliminarFactura;
        private System.Windows.Forms.Button btnGuardarFactura;
        private System.Windows.Forms.Button btnNuevaFactura;
        private System.Windows.Forms.Button btnBuscarFcatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
    }
}