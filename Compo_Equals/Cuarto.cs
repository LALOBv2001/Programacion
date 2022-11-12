using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compo_Equals
{
    class Cuarto:IEquatable<Cuarto>
    {
		public Cuarto(string a,int b,bool c,double d,DateTime e)
		{
			NombreCuarto = a;
			CantidadDeTeles = b;
			Abanicos = c;
			PrecioConstruccion = d;
			FechaConstruccion = e;
		}
		public Cuarto()
		{ 
		}

		private int _intCantidadDeTeles;

		public int CantidadDeTeles
		{
			get { return _intCantidadDeTeles; }
			set { _intCantidadDeTeles = value; }
		}
		private bool _blnAbanicos;

		public bool Abanicos
		{
			get { return _blnAbanicos; }
			set { _blnAbanicos = value; }
		}
		private string _strNombreCuarto;

		public string NombreCuarto
		{
			get { return _strNombreCuarto; }
			set { _strNombreCuarto = value; }
		}
		private double _dblPrecioConstruccion;

		public double PrecioConstruccion
		{
			get { return _dblPrecioConstruccion; }
			set { _dblPrecioConstruccion = value; }
		}
		private DateTime _dtmFechaConstruccion;

		public DateTime FechaConstruccion
		{
			get { return _dtmFechaConstruccion; }
			set { _dtmFechaConstruccion = value; }
		}
		public  bool Equals(Cuarto otroCuarto)
		{
			return (this.NombreCuarto==otroCuarto.NombreCuarto);
		}






	}
}
