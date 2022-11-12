using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseParametricaProducto
{
    public partial class Form1 : Form
    {
        // Unidad 4

// Programa 4

// Autor: Eduardo Pérez Escobar

// No. Control: 19100236

// Descripción: Este programa captura datos, los agrega a una lista de objetos y se muestra en un datagridview
        //Declaracion y creacion de un objeto global para la lista de productos
        List<Producto> miListaProductos = new List<Producto>();
        Producto miProducto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "" || dtpFecha.Value == null)//Validamos que no haya un dato vacio
            {
                MessageBox.Show("No se debe dejar espacios en blanco.", "Error.");//Mensaje
            }
            else
            {
                miProducto = new Producto(txtNombre.Text,int.Parse(txtCantidad.Text),double.Parse(txtPrecio.Text),DateTime.Parse(dtpFecha.Text));//Instancia de objeto
                dataGridView1.Rows.Add(txtNombre.Text, int.Parse(txtCantidad.Text), double.Parse(txtPrecio.Text).ToString("C"), DateTime.Parse(dtpFecha.Text));//Le mandamos los valores al dataGridView
                miListaProductos.Add(miProducto);//Agregamos el objeto a la lista
                foreach (Control c in grbDatosProducto.Controls)
                    if (c is TextBox)
                        c.Text = "";//Vaciamos textbox
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar numeros mayores a 0", "Advertencia");
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
