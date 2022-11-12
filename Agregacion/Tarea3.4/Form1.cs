using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3._4
{
    public partial class Form1 : Form
    {
        EstantePelicula miEstante;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            miEstante = new EstantePelicula();
            miEstante.NumeroRepisas = int.Parse(txtNumeroRepisas.Text);
            miEstante.Color = txtColor.Text;

            MessageBox.Show("Datos del estante capturados", "ESTANTE", MessageBoxButtons.OK);
            {
                foreach (Control c in grbDatosEstante.Controls)
                    if (c is TextBox)
                        c.Text = "";
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            EstuchePelicula miEstuche = new EstuchePelicula();
            miEstuche.CantidadDiscos = int.Parse(txtCantidadDiscos.Text);
            miEstuche.Precio = double.Parse(txtPrecio.Text);
            miEstuche.Nombre = txtNombre.Text;

            if (radC.Checked || radD.Checked)
            { miEstuche.PeliculaMayorEdad = true; }
            else { miEstuche.PeliculaMayorEdad = false; }
            if (radA.Checked)
            { miEstuche.Clasificacion = 'A'; }
            else if (radB.Checked)
            { miEstuche.Clasificacion = 'B'; }
            else if (radC.Checked)
            { miEstuche.Clasificacion = 'C'; }
            else if (radD.Checked)
            { miEstuche.Clasificacion = 'D'; }


            miEstante.InsertarEstuche(miEstuche);
            dataGridView1.Rows.Clear();
            foreach (EstuchePelicula x in miEstante)
            {
                dataGridView1.Rows.Add(x.Nombre, x.Precio.ToString("C"), x.Clasificacion, x.CantidadDiscos, x.PeliculaMayorEdad);
            }
            MessageBox.Show("Datos del estuche capturados ", "ESTUCHE", MessageBoxButtons.OK);
            foreach (Control c in grbDatosEstuche.Controls)
                if (c is TextBox)
                    c.Text = "";
        }

        private void btnTotalDiscos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad de discos totales:" + miEstante.SumarDiscos());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
