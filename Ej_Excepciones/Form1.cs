using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Empleado miEmpleado = new Empleado();
            try
            {
                miEmpleado.Numero = int.Parse(txtNumero.Text);
                miEmpleado.Nombre = txtNombre.Text;
                miEmpleado.Edad = int.Parse(txtEdad.Text);

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txtNumero.Text = "";
                txtEdad.Text = "";
                txtNombre.Text = "";
                txtNumero.Focus();
                return;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
