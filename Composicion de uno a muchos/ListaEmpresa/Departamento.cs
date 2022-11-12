using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEmpresa
{
    class Departamento
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
		private string _strJefe;

		public string Jefe
		{
			get { return _strJefe; }
			set { _strJefe = value; }
		}
		public Departamento(int a, string b, string c)
		{
			Numero = a;
			Nombre = b;
			Jefe = c;
		}
	}
}
