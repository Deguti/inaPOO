namespace _01_CapaPresentracion
{
    partial class AdministracionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionProductos));
            this.btnSalirProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lblDescribcionProducto = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirProducto
            // 
            this.btnSalirProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirProducto.Image")));
            this.btnSalirProducto.Location = new System.Drawing.Point(648, 343);
            this.btnSalirProducto.Name = "btnSalirProducto";
            this.btnSalirProducto.Size = new System.Drawing.Size(119, 78);
            this.btnSalirProducto.TabIndex = 27;
            this.btnSalirProducto.Text = "&Salir";
            this.btnSalirProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalirProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Image")));
            this.btnEliminarProducto.Location = new System.Drawing.Point(407, 343);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(119, 78);
            this.btnEliminarProducto.TabIndex = 26;
            this.btnEliminarProducto.Text = "&Eliminar";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProducto.Image")));
            this.btnGuardarProducto.Location = new System.Drawing.Point(283, 343);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(119, 78);
            this.btnGuardarProducto.TabIndex = 25;
            this.btnGuardarProducto.Text = "&Guardar";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProducto.Image")));
            this.btnNuevoProducto.Location = new System.Drawing.Point(159, 343);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(119, 78);
            this.btnNuevoProducto.TabIndex = 24;
            this.btnNuevoProducto.Text = "&Nuevo";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(34, 343);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(119, 78);
            this.btnBuscarProducto.TabIndex = 23;
            this.btnBuscarProducto.Text = "&Buscar";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.precioVenta,
            this.precioCompra,
            this.descripcion,
            this.grabado});
            this.dgvProductos.Location = new System.Drawing.Point(34, 197);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(732, 140);
            this.dgvProductos.TabIndex = 22;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(34, 113);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(732, 78);
            this.txtDescripcionProducto.TabIndex = 21;
            // 
            // lblDescribcionProducto
            // 
            this.lblDescribcionProducto.AutoSize = true;
            this.lblDescribcionProducto.Location = new System.Drawing.Point(34, 95);
            this.lblDescribcionProducto.Name = "lblDescribcionProducto";
            this.lblDescribcionProducto.Size = new System.Drawing.Size(140, 15);
            this.lblDescribcionProducto.TabIndex = 20;
            this.lblDescribcionProducto.Text = "Descripción del producto";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(455, 58);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioCompra.TabIndex = 19;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(332, 58);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(88, 23);
            this.txtPrecioVenta.TabIndex = 18;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(34, 58);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(114, 23);
            this.txtCodigoProducto.TabIndex = 17;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(455, 29);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(102, 15);
            this.lblPrecioCompra.TabIndex = 16;
            this.lblPrecioCompra.Text = "Precio de Compra";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(332, 29);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(88, 15);
            this.lblPrecioVenta.TabIndex = 15;
            this.lblPrecioVenta.Text = "Precio de Venta";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(34, 29);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(114, 15);
            this.lblCodigoProducto.TabIndex = 14;
            this.lblCodigoProducto.Text = "Código de Producto";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "ID_PRODUCTO";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // precioVenta
            // 
            this.precioVenta.DataPropertyName = "PRECIO_VENTA";
            this.precioVenta.HeaderText = "Precio de Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.Width = 200;
            // 
            // precioCompra
            // 
            this.precioCompra.DataPropertyName = "PRECIO_COMPRA";
            this.precioCompra.HeaderText = "Precio de Compra";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.Width = 200;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "DESCRIPCION";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 200;
            // 
            // grabado
            // 
            this.grabado.DataPropertyName = "GRABADO";
            this.grabado.HeaderText = "Grabado";
            this.grabado.Name = "grabado";
            this.grabado.Visible = false;
            // 
            // AdministracionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.lblDescribcionProducto);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblCodigoProducto);
            this.Name = "AdministracionProductos";
            this.Text = "AdministracionProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label lblDescribcionProducto;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn grabado;
    }
}