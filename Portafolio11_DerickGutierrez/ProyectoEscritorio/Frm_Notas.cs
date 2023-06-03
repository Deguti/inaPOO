using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEscritorio
{
    public partial class Frm_Notas : Form
    {
        public Frm_Notas()
        {
            InitializeComponent();
        }

        //Procedimiento para limpiar y asignar color amarillo
        private void LimpiarEtiquetaPromedio()
        {
            txtResultado.BackColor = SystemColors.Info;
            txtResultado.Text = string.Empty;
        }

        // Función para calcular la suma de las notas y devolver el monto total
        private double CalcularSumaNotas(List<double>notas)
        {
            double suma = 0;
            foreach (double nota in notas)
            {
                suma+= nota;
            }
            return suma;
        }

        //Evento que agrega las notas a la lista
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación de la nota ingresada
            if (!string.IsNullOrEmpty(txtNota.Text))
            {
                if (double.TryParse(txtNota.Text, out double nota))
                {
                    if (nota <= 100 && nota > 0)
                    {
                        // Agregar la nota a la lista
                        listNotas.Items.Add(nota.ToString());
                        LimpiarEtiquetaPromedio();
                        txtNota.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("La nota no puede ser mayor a 100.o menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El valor ingresado debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listNotas_MouseClick(object sender, MouseEventArgs e)
        {
            txtNotaSeleccionada.Text = listNotas.Text;

        }


        /*
         el sistema verifica si el usuario seleccionó alguna nota de la lista. 
        Se debe quitar la nota seleccionada de la lista, se limpia el campo de texto de la nota seleccionada y 
        por último se hace un llamado al procedimiento que limpia los datos del promedio.
         */
        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            if (listNotas.SelectedIndex != -1)
            {
                    listNotas.Items.Remove(listNotas.SelectedItem); // Eliminar la nota seleccionada de la lista
                    txtNotaSeleccionada.Clear(); // Limpiar el campo de texto de la nota
                    LimpiarEtiquetaPromedio(); // Llamar al procedimiento para limpiar el resultado del promedio
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una nota de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Limpiar la lista
        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            listNotas.Items.Clear(); // Eliminar la nota seleccionada de la lista
            txtNotaSeleccionada.Clear(); // Limpiar el campo de texto de la nota
            LimpiarEtiquetaPromedio(); // Llamar al procedimiento para limpiar el resultado del promedio 
        }

        //evento Calcular resultado
        private void btnResultado_Click(object sender, EventArgs e)
        {
            List<double> listaDeNotas = new List<double>();//creacion de instancia para almacenar los valores de la lista en tipo numerico
            foreach (var item in listNotas.Items)
            {
                listaDeNotas.Add(double.Parse(item.ToString()));//se convierte el valor de tipo objeto a tipo numerico
            }
            double sumanota = CalcularSumaNotas(listaDeNotas);
            ClsPromedio calPromedio = new ClsPromedio();
            calPromedio.CalcularPromedio(sumanota, listaDeNotas.Count);
            calPromedio.CalcularCondicion(calPromedio.Promedio);
            double promedio = calPromedio.Promedio;
            string color = calPromedio.Color;
            txtResultado.Text = Math.Round( calPromedio.Promedio, 2) + " "+ calPromedio.Condicion;
            if (color =="Red")
            {
                txtResultado.BackColor = Color.Red;
            }
            else
            {
                txtResultado.BackColor = Color.Green;
            }
        }

        
    }

}
