namespace ProyectoEscritorio
{
    partial class Frm_Notas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listNotas = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.txtNotaSeleccionada = new System.Windows.Forms.TextBox();
            this.lblNotaSeleccionada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listNotas);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.btnResultado);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnLimpiarLista);
            this.groupBox1.Controls.Add(this.btnEliminarSeleccionado);
            this.groupBox1.Controls.Add(this.txtNotaSeleccionada);
            this.groupBox1.Controls.Add(this.lblNotaSeleccionada);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.lblNota);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Notas";
            // 
            // listNotas
            // 
            this.listNotas.FormattingEnabled = true;
            this.listNotas.ItemHeight = 15;
            this.listNotas.Location = new System.Drawing.Point(285, 22);
            this.listNotas.Name = "listNotas";
            this.listNotas.Size = new System.Drawing.Size(160, 259);
            this.listNotas.TabIndex = 12;
            this.listNotas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listNotas_MouseClick);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(10, 235);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(269, 46);
            this.txtResultado.TabIndex = 11;
            // 
            // btnResultado
            // 
            this.btnResultado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResultado.Location = new System.Drawing.Point(168, 206);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(100, 23);
            this.btnResultado.TabIndex = 10;
            this.btnResultado.Text = "Ver Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(13, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 1);
            this.panel2.TabIndex = 9;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiarLista.Location = new System.Drawing.Point(10, 163);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(158, 30);
            this.btnLimpiarLista.TabIndex = 8;
            this.btnLimpiarLista.Text = "Limpiar Lista de Notas";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(10, 118);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(158, 30);
            this.btnEliminarSeleccionado.TabIndex = 7;
            this.btnEliminarSeleccionado.Text = "Eliminar Seleccionado";
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // txtNotaSeleccionada
            // 
            this.txtNotaSeleccionada.Enabled = false;
            this.txtNotaSeleccionada.Location = new System.Drawing.Point(168, 75);
            this.txtNotaSeleccionada.Name = "txtNotaSeleccionada";
            this.txtNotaSeleccionada.Size = new System.Drawing.Size(100, 23);
            this.txtNotaSeleccionada.TabIndex = 6;
            // 
            // lblNotaSeleccionada
            // 
            this.lblNotaSeleccionada.AutoSize = true;
            this.lblNotaSeleccionada.Location = new System.Drawing.Point(10, 75);
            this.lblNotaSeleccionada.Name = "lblNotaSeleccionada";
            this.lblNotaSeleccionada.Size = new System.Drawing.Size(105, 15);
            this.lblNotaSeleccionada.TabIndex = 5;
            this.lblNotaSeleccionada.Text = "Nota Seleccionada";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(13, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 1);
            this.panel1.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(193, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(98, 30);
            this.txtNota.MaxLength = 4;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(77, 23);
            this.txtNota.TabIndex = 1;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(10, 38);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(82, 15);
            this.lblNota.TabIndex = 0;
            this.lblNota.Text = "Digite la Nota:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(388, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Frm_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Notas";
            this.Text = "Registro de  Notas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.TextBox txtNotaSeleccionada;
        private System.Windows.Forms.Label lblNotaSeleccionada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listNotas;
    }
}