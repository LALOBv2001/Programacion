using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolimorfismoParametrico
{
    class Cliente
    {
        //Atributos con propiedades
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private string _strRFC;

        public string RFC
        {
            get { return _strRFC; }
            set { _strRFC = value; }
        }
        private int _intNumeroTarjeta;

        public int NumeroTarjeta
        {
            get { return _intNumeroTarjeta; }
            set { _intNumeroTarjeta = value; }
        }
        private string _strClave;

        public string Clave
        {
            get { return _strClave; }
            set { _strClave = value; }
        }
        private double _dblCantidad;

        public double Cantidad
        {
            get { return _dblCantidad; }
            set { _dblCantidad = value; }
        }
        private string _strDireccion;

        public string Direccion
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }





        //Metodos
        public void Pagar(double dblCantidadPagar)//Metodo para pagon en efectivo
        {
            _dblCantidad = dblCantidadPagar;
            MessageBox.Show("  PAGO EN EFECTIVO POR: $ " + dblCantidadPagar + ".");
        }
        public void Pagar(int intNumeroDeTarjeta, int Dv, double dblCantidadPagar)//Metodo para pago con trajeta
        {
            _intNumeroTarjeta = intNumeroDeTarjeta;
            _dblCantidad = dblCantidadPagar;
            MessageBox.Show("  PAGO REALIZADO CON TARJETA:  " + intNumeroDeTarjeta + "  POR UN SALDO DE : $" + dblCantidadPagar + ".");
        }
        public void Pagar(string strClaveInter, double dblCantidadPagar)//Metodo para pago con trasnferencia bancaria
        {
            _strClave = strClaveInter;
            _dblCantidad = dblCantidadPagar;
            MessageBox.Show("  PAGO POR TRANFERENCIA ELECTRONICA A LA CUENTA:  " + strClaveInter + "  POR UN SALDO DE : $" + dblCantidadPagar + ".");
        }
    }
}
