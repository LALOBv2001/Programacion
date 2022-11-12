using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjPolimorfismo2
{
    // Unidad 4

// Programa 3

// Autor: Eduardo Pérez Escobar

// No. Control: 19100236

// Descripción: Este programa captura datos y despliega varios mensajes en la pantalla 
    public partial class Form1 : Form
    {
        //Creacion global de los objetos 
        Hamburguesa miHamburguesa = new Hamburguesa();
        PapasFritas misPapas = new PapasFritas();
        Refresco miRefresco = new Refresco();
        PayManzana miPay = new PayManzana();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //El combobox queda deshabilitado para meterle datos
            cmbTHamburguesa.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSAlir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Opcion = cmbTHamburguesa.Text;//variable local que agarra el valor del cmb del tipo de hamburguesa y de
            //dependiendo de la opcion se activan o desactivan ciertos txt
            switch (Opcion)
            {
                case "Sencilla": 
                    grbDatosHamburguesa.Enabled = false;
                    ; break;
                case "Doble con queso":
                    grbDatosHamburguesa.Enabled = true;
                    txtChampinones.Enabled = false;
                    txtCarne.Enabled = true;
                    txtQueso.Enabled = true;
                    txtJalapenos.Enabled = false;
                    ; break;
                case "Con champiñones":
                    txtChampinones.Enabled = true;
                    txtCarne.Enabled = true;
                    txtQueso.Enabled = true;
                    grbDatosHamburguesa.Enabled = true;
                    txtJalapenos.Enabled = false;

                    ; break;
                case "Con jalapeños":
                    txtChampinones.Enabled = false;
                    txtCarne.Enabled = false;
                    txtQueso.Enabled = false;
                    txtJalapenos.Enabled = true;
                    grbDatosHamburguesa.Enabled = true; ; break;
                default:
                    MessageBox.Show("OPcion incorrecta.");

                    break;
            }
        }

        private void rdbHamburguesa_CheckedChanged(object sender, EventArgs e)
        {
            //Dependiendo del radio button se activan o se desactivan ciertos controles
            cmbTHamburguesa.Enabled = true;
            grbDatosHamburguesa.Enabled = true;
            txtHielo.Enabled = false;


        }

        private void rdbPapas_CheckedChanged(object sender, EventArgs e)
        {
            cmbTHamburguesa.Enabled = false;
            grbDatosHamburguesa.Enabled = false;
            txtHielo.Enabled = false;


        }

        private void rdbRefresco_CheckedChanged(object sender, EventArgs e)
        {
            cmbTHamburguesa.Enabled = false;
            grbDatosHamburguesa.Enabled = false;
            txtHielo.Enabled = true;
 


        }

        private void rdbPayManzana_CheckedChanged(object sender, EventArgs e)
        {
            cmbTHamburguesa.Enabled = false;
            grbDatosHamburguesa.Enabled = false;
            txtHielo.Enabled = false;


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Dependiendo del rdb va a mostrar su forma de preparacion
            if (rdbHamburguesa.Checked)
            {
                miHamburguesa.MetodoPreparacion();
            }
            else if (rdbPapas.Checked)
            {
                misPapas.MetodoPreparacion();
            }
            else if (rdbRefresco.Checked)
            {
                miRefresco.MetodoPreparacion();
            }
            else
            {
                miPay.MetodoPreparacion();
            }
        }

        private void grbDatosHamburguesa_Enter(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                //Lanza un mensaje si se dejan los espacios en blanco
                if (txtNombre.Text==""||txtcategoria.Text==""||double.Parse(txtPrecio.Text)<0||txtPrecio.Text=="")
                {
                    throw new Exception("NO SE PUEDEN DEJAR ESPACIOS EN BLANCO Y EL PRECIO NO PUEDE SER MENOR A 0.");
                }
                else
                {
                    //Dependiendo del rdb se captura los datos del objeto
                    if (rdbHamburguesa.Checked)
                    {
                        miHamburguesa.Nombre = txtNombre.Text;
                        miHamburguesa.Precio = double.Parse(txtPrecio.Text);
                        miHamburguesa.Categoria = txtcategoria.Text;
                        string Opcion = cmbTHamburguesa.Text;//Variable local que agarra el valor de cmb
                        switch (Opcion)
                        {
                            //Dependiendo de la opcion del usuario y los datos capturados se manda a llamar un metodo de la hamburguesa
                            case "Sencilla": MessageBox.Show("Datos de la hamburguesa sencilla captrados") ; miHamburguesa.MetodoPreparacion(); break;
                            case "Doble con queso":
                                miHamburguesa.MetodoPreparacion(int.Parse(txtCarne.Text),int.Parse(txtQueso.Text),false);
                                ; break;
                            case "Con champiñones":
                                miHamburguesa.MetodoPreparacion(int.Parse(txtCarne.Text), int.Parse(txtQueso.Text), true);
                                ; break;
                            case "Con jalapeños":
                              miHamburguesa.MetodoPreparacion(int.Parse(txtJalapenos.Text)); break;
                            default:
                                MessageBox.Show("OPcion incorrecta."); break;
                        }
                        //Se confirma los datos ingresados y se limpian todos los txt
                        MessageBox.Show("Datos de la hamburguesa capturados");
                        txtCarne.Text = "";
                        txtcategoria.Text = "";
                        txtChampinones.Text = "";
                        txtJalapenos.Text = "";
                        txtNombre.Text = "";
                        txtPrecio.Text = "";
                        txtQueso.Text = "";
                        txtHielo.Text = "";

                    }
                    else if (rdbPapas.Checked)
                    {
                        misPapas.Nombre = txtNombre.Text;
                        misPapas.Precio = double.Parse(txtPrecio.Text);
                        misPapas.Categoria = txtcategoria.Text;
                        MessageBox.Show("Datos de las papas "+misPapas.Nombre+" capturadas");
                        txtCarne.Text = "";
                        txtcategoria.Text = "";
                        txtChampinones.Text = "";
                        txtJalapenos.Text = "";
                        txtNombre.Text = "";
                        txtPrecio.Text = "";
                        txtQueso.Text = "";
                        txtHielo.Text = "";

                    }
                    else if (rdbRefresco.Checked)
                    {
                        miRefresco.Nombre = txtNombre.Text;
                        miRefresco.Precio = double.Parse(txtPrecio.Text);
                        miRefresco.Categoria = txtcategoria.Text;
                        miRefresco.MetodoPreparacion(int.Parse(txtHielo.Text));
                        MessageBox.Show("Datos del refresco de "+miRefresco.Precio.ToString("C")+" capturados");
                        txtCarne.Text = "";
                        txtcategoria.Text = "";
                        txtChampinones.Text = "";
                        txtJalapenos.Text = "";
                        txtNombre.Text = "";
                        txtPrecio.Text = "";
                        txtQueso.Text = "";
                        txtHielo.Text = "";

                    }
                    else
                    {
                        miPay.Nombre = txtNombre.Text;
                        miPay.Precio = double.Parse(txtPrecio.Text);
                        miPay.Categoria = txtcategoria.Text;
                        MessageBox.Show("Datos del pay de "+miPay.Precio.ToString("C")+" capturados");
                        txtCarne.Text = "";
                        txtcategoria.Text = "";
                        txtChampinones.Text = "";
                        txtJalapenos.Text = "";
                        txtNombre.Text = "";
                        txtPrecio.Text = "";
                        txtQueso.Text = "";
                        txtHielo.Text = "";

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"ERROR");
            }
        }
    }
}
