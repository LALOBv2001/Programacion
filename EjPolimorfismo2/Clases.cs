using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjPolimorfismo2
{
    class Hamburguesa
    {
         
        //Atributos con propiedad
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }
        private string _strCategoria;

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }
        //Metodos
        public void MetodoPreparacion()
        {
            //Hamburguesa sencilla
            MessageBox.Show("Se esta preparando una hamburguesa sencilla");
        }

        public void MetodoPreparacion(int Carne, int Queso, bool Champiñon)
        {
            //Hamburguesa con 2 ingredientes
            if (Champiñon)
            { //Preparar hamburguesa de queso con champiñones
                MessageBox.Show("Se esta preparando una deliciosa hamburguesa con queso con champiñones, la cual debe llevar " + Carne + " gr de champiñones" + Queso + " rebanadas de queso");
            }
            else
            {
                //Preparar hamburguesa doble con queso
                MessageBox.Show("Se esta preparando una suculenta hamburguesa doble con queso, la cual debe llevar " + Carne + " carne y " + Queso + " rebanadas de queso");
            }

        }
        public void MetodoPreparacion(int jalapeno)
        { //Hamburguesa con jalapeño
            MessageBox.Show("Este es el metodo para preparar una hamburguesa con " + jalapeno + " jalapeño(s)");

        }
    }
    class PapasFritas
    {
        //Atributos con propiedad
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }
        private string _strCategoria;

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }


        //Metodos
        public void MetodoPreparacion()
        {
            MessageBox.Show("Las papas fritas se frien en aceite por 10 minutos.");
        }
    }
    class Refresco
    {
        //Atributos con propiedad
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }
        private string _strCategoria;

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }


        //Metodos
        public void MetodoPreparacion(int hielo)
        {
            if (hielo>0)
            {
                MessageBox.Show("El refresco con "+hielo+" hielo(s) se esta sirviendo...");
            }
            else
            MessageBox.Show("El refresco sin hielo se esta sirviendo...");
        }
        public void MetodoPreparacion()
        {
            MessageBox.Show("El refresco se esta sirviendo.");
        }

    }
    class PayManzana
    {
        //Atributos con propiedad
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }
        private string _strCategoria;

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }


        //Metodos
        public void MetodoPreparacion()
        {
            MessageBox.Show("El pay de manzana se esta horneando a 200°C por 10 minutos.");
        }
    }
}
