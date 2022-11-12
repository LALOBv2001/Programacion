using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEmpresa
{
    public partial class Form1 : Form
    {
        Empresa miEmpresa;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            miEmpresa = new Empresa(txtRFC.Text, txtRazonSocial.Text, txtGerente.Text);
            MessageBox.Show("Datos de la empresa capturados", "Empresa", MessageBoxButtons.OK);
            {
                foreach (Control c in grbDatosEmpresa.Controls)
                    if (c is TextBox)
                        c.Text = "";
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            Departamento miDepartamento = new Departamento(int.Parse(txtNumero.Text), txtNombre.Text, txtJefe.Text);

            miEmpresa.InsertarDepartamento(miDepartamento);
            dataGridView1.Rows.Clear();
            foreach (Departamento x in miEmpresa)
            {
                dataGridView1.Rows.Add(x.Numero, x.Nombre, x.Jefe);
            }
            MessageBox.Show("Datos del departamento capturados", "Departamento", MessageBoxButtons.OK);
            foreach (Control c in grbDatosDepartamento.Controls)
                if (c is TextBox)
                    c.Text = "";
        }
    }
}
