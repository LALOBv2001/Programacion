using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjPolimorfismo1
{
    public partial class Form1 : Form
    {
        // Unidad 4

         // Programa 2

        // Autor: Eduardo Pérez Escobar

           // No. Control: 19100236 
       // Descripción: Este programa captura y despliega varios mensajes en la pantalla. 
        //Instancia del objeto
        Carro miCarro;
        public Form1()
        {
            InitializeComponent();
        }

        private void grbDatosAuto_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                int intContadorVacios = 0;//variable local que acumula el numero de txt vacios
                foreach (Control c in grbDatosAuto.Controls)
                {
                    if (c is TextBox && c.Text == "")
                    {
                        intContadorVacios++;
                    }
                
                }
                if (intContadorVacios > 0 || double.Parse(txtVelocidad.Text) < 0 || int.Parse(txtCaballosFuerza.Text) < 0 || int.Parse(txtNumLLantas.Text) < 0 || int.Parse(txtNumPuertas.Text) < 0)
                    //si los valores ingresados son menores a 0 o el contador de vacios es mayor a 0 sale una excepcion
                {
                    throw new Exception("NO SE PUEDEN DEJAR ESPACIOS VACIOS Y MUCHO MENOS UNA CIFRA\nPUEDE SER MENOR A 0.");
                }
                else 
                {
                    //Creacion y asigancion de valores al objeto
                    miCarro = new Carro(int.Parse(txtCaballosFuerza.Text),int.Parse(txtNumPuertas.Text),double.Parse(txtVelocidad.Text),int.Parse(txtNumLLantas.Text));
                    MessageBox.Show("DATOS CAPTURADOS DEL AUTO.");//mbox para confirmar los datos y limpieza de los txt
                    foreach (Control c in grbDatosAuto.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)//Excepcion por si algo sale mal
            {
                MessageBox.Show(ex.Message,"ERROR");

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //acciones de los objetos
            miCarro.Encender();
            miCarro.Avanzar();
            miCarro.MostrarMensaje();
        }
    }
}
