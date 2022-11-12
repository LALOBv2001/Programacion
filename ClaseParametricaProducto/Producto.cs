using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParametricaProducto
{
    class Producto
    {
        //atributos y propiedades
        private int _intCantidad;

        public int Cantidad
        {
            get { return _intCantidad; }
            set { _intCantidad = value; }
        }
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
        private DateTime _dtmFechaCompra;

        public DateTime FechaCompra 
        {
            get { return _dtmFechaCompra; }
            set { _dtmFechaCompra = value; }
        }

        public Producto(string N,int C,double P,DateTime F)//Constructor con parametros
        {
            Nombre = N;
            Cantidad = C;
            Precio = P;
            FechaCompra = F;
        }
    }
}
