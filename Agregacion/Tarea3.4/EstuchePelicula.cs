using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3._4
{
    class EstuchePelicula
    {
		private int _intCantidadDiscos;

		public int CantidadDiscos
		{
			get { return _intCantidadDiscos; }
			set { _intCantidadDiscos = value; }
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
		private char _chrClasificacion;

		public char Clasificacion
		{
			get { return _chrClasificacion; }
			set { _chrClasificacion = value; }
		}
		private bool _blnPeliculaMayorEdad;

		public bool PeliculaMayorEdad
		{
			get { return _blnPeliculaMayorEdad; }
			set { _blnPeliculaMayorEdad = value; }
		}
	}
}
