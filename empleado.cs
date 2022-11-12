using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenericaDeEmpleados
{
    class Empleado 
    {
		private int _intNumero;

		public int Numero
		{
			get { return _intNumero; }
			set { _intNumero = value; }
		}
		private string _strNombre;

		public string Nombre
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}
		private double  _dblSueldo;

		public double  Sueldo 
		{
			get { return _dblSueldo; }
			set { _dblSueldo = value; }
		}



	}
}
