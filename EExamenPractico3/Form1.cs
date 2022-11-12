using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EExamenPractico3
{
    public partial class Form1 : Form
    {
        PacienteTraumatologia miPaciente1 = new PacienteTraumatologia();
        PacienteTraumatologia miPaciente2 = new PacienteTraumatologia();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (rdbPaciente1.Checked)
            {
                miPaciente1.Nombre = txtNombre.Text;
                miPaciente1.Sexo = cmbSexo.Text;
                miPaciente1.Edad = int.Parse(txtEdad.Text);
                miPaciente1.Padecimiento = cmbPadecimiento.Text;
                miPaciente1.CostoTratamiento = double.Parse(txtCostoTratamiento.Text);
                miPaciente1.CostoConsultaGeneral = double.Parse(txtCostoConsultaGeneral.Text);
                foreach (Control c in groupBox1.Controls)
                    if (c is TextBox)
                        c.Text = "";
                MessageBox.Show("Datos Capturados del primer paciente");
            }
            else
            {
                miPaciente2.Nombre = txtNombre.Text;
                miPaciente2.Sexo = cmbSexo.Text;
                miPaciente2.Edad = int.Parse(txtEdad.Text);
                miPaciente2.Padecimiento = cmbPadecimiento.Text;
                miPaciente2.CostoTratamiento = double.Parse(txtCostoTratamiento.Text);
                miPaciente2.CostoConsultaGeneral = double.Parse(txtCostoConsultaGeneral.Text);
                foreach (Control c in groupBox1.Controls)
                    if (c is TextBox)
                        c.Text = "";
                MessageBox.Show("Datos Capturados del segundo paciente");

            }

        }

        private void btnMostrarPagarMenos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre del paciente que paga menos:" +miPaciente1.PagarMenos(miPaciente2));
        }
    }
}
