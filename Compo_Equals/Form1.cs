using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compo_Equals
{
    public partial class Form1 : Form
    {
        Casa miCasa;
        Cuarto miCuarto;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblMes.Text = DateTime.Now.ToLongDateString();
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void lblMes_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

          
                Cuarto cuartoEliminar = new Cuarto();
             cuartoEliminar.NombreCuarto = (string)(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            cuartoEliminar.CantidadDeTeles = (int)(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value);
            cuartoEliminar.Abanicos = (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString() == "Si") ? true : false;
            cuartoEliminar.FechaConstruccion = (DateTime)(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                miCasa.Eliminar(cuartoEliminar);
            
            MessageBox.Show("Cuarto eliminado °u° \nHasta luego,vuelva pronto. uwu");

            
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click_1(object sender, EventArgs e)
        {
            miCasa = new Casa();
            bool a= (rdbSi.Checked) ? true : false;
            miCuarto = new Cuarto(txtNombre.Text,int.Parse(txtCantidadDeTeles.Text),a,double.Parse(txtPrecioCuarto.Text),DateTime.Parse(dtmFechaConstruccion.Text));
            miCasa.InsertarCuarto(miCuarto);
             foreach (Cuarto x in miCasa)
            {
                if(x.Abanicos == true)
                dataGridView1.Rows.Add(x.NombreCuarto, x.CantidadDeTeles, "Si", x.PrecioConstruccion.ToString("C"), x.FechaConstruccion);
                else
                    dataGridView1.Rows.Add(x.NombreCuarto, x.CantidadDeTeles, "NO", x.PrecioConstruccion.ToString("C"), x.FechaConstruccion);

            }
            MessageBox.Show("Datos del cuarto capturados ", "CUARTO", MessageBoxButtons.OK);
            foreach (Control c in grbDatos.Controls)
                if (c is TextBox)
                    c.Text = "";
        }
    }
}
