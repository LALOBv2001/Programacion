using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaGenericaDeEmpleados
{
    public partial class Form1 : Form
    {
        Empleado miEmpleado;
        List<Empleado> miEmpresa;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            miEmpleado = new Empleado();
            miEmpleado.Numero = int.Parse(txtNumero.Text);
            miEmpleado.Nombre = txtNombre.Text;
            miEmpleado.Sueldo = double.Parse(txtSueldo.Text);

           miEmpresa = new List<Empleado>();
            miEmpresa.Add(miEmpleado);

            
            foreach (Empleado miEmpleado in miEmpresa)
            {
                dataGridView1.Rows.Add(miEmpleado.Numero, miEmpleado.Nombre, miEmpleado.Sueldo.ToString("C"));
            }
            
                foreach (Control c in grbDatosEmpleados.Controls)
                    if (c is TextBox)
                        c.Text = "";
            

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            foreach (Empleado miEmpleado in miEmpresa)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow); 
                MessageBox.Show("Empleado eliminado C: \nHasta luego,vuelva pronto. uwu");

            }
            miEmpleado = null;

        }
    }
}
