using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolimorfismoParametrico
{
    // Unidad 4

    // Programa 1 

    // Autor: Eduardo Pérez Escobar

    // No. Control: 19100236

    // Descripción: Este programa captura los datos del ususario 
    //y su manera de pago, implementamos polimorfismo parametrico 
    //para regresar el mensaje en pantalla
    public partial class Form1 : Form
    {
        //Creacion global del objeto
        Cliente miCliente = new Cliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbTransferenciaElectronica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEfectivo.Checked)
            {
                txtCCV.Enabled = false;
                txtClaveInterbancaria.Enabled = false;
                txtNumTarjeta.Enabled = false;
            }
            else
            {
                if (rdbTarjeta.Checked)
                {
                    txtCCV.Enabled = true;
                    txtClaveInterbancaria.Enabled = false;
                    txtNumTarjeta.Enabled = true;
                }
                else
                {
                    txtCCV.Enabled = false;
                    txtNumTarjeta.Enabled = false;
                    txtClaveInterbancaria.Enabled = true;
                }
            }
        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEfectivo.Checked)
            {
                txtCCV.Enabled = false;
                txtClaveInterbancaria.Enabled = false;
                txtNumTarjeta.Enabled = false;
            }
            else
            {
                if (rdbTarjeta.Checked)
                {
                    txtCCV.Enabled = true;
                    txtClaveInterbancaria.Enabled = false;
                    txtNumTarjeta.Enabled = true;
                }
                else
                {
                    txtCCV.Enabled = false;
                    txtNumTarjeta.Enabled = false;
                    txtClaveInterbancaria.Enabled = true;
                }
            }
        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            //Se desactivan los txt dependiendo del radiobutton
            if (rdbEfectivo.Checked)
            {
                txtCCV.Enabled = false;
                txtClaveInterbancaria.Enabled = false;
                txtNumTarjeta.Enabled = false;
            }
            else
            {
                if (rdbTarjeta.Checked)
                {
                    txtCCV.Enabled = true;
                    txtClaveInterbancaria.Enabled = false;
                    txtNumTarjeta.Enabled = true;
                }
                else
                {
                    txtCCV.Enabled = false;
                    txtNumTarjeta.Enabled = false;
                    txtClaveInterbancaria.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnPagar_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtNombre.Text == "" || txtRFC.Text == ""||txtDireccion.Text=="")//Validamos que no queden en blanco
                {
                    MessageBox.Show("NO SE PUEDEN DEJAR ESPACIOS EN BLACO.");
                }
                else
                {
                    //Guarda en propiedades datos del cliente
                    miCliente.Nombre = txtNombre.Text;
                    miCliente.Direccion = txtDireccion.Text;
                    miCliente.RFC = txtRFC.Text;
                    MessageBox.Show("Datos capturados");
                    //Invoca el metodo de pago de acuerdo a selec
                    if (rdbEfectivo.Checked)
                    {
                        miCliente.Pagar(double.Parse(txtCPagar.Text));
                    }
                    else
                    {
                        if (rdbTarjeta.Checked)
                            miCliente.Pagar(int.Parse(txtNumTarjeta.Text), int.Parse(txtCCV.Text), double.Parse(txtCPagar.Text));
                        else
                            miCliente.Pagar(txtClaveInterbancaria.Text, double.Parse(txtCPagar.Text));
                    }
                    txtNombre.Text = "";
                    txtDireccion.Text = "";
                    txtRFC.Text = "";
                    foreach (Control c in grbPagar.Controls)
                        if (c is TextBox)
                            c.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Al parecer algo salio mal");

            }
        }
    }
}


