using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamenPractico3
{
    abstract class Paciente
    {
		private string _strNombre;

		public string Nombre
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}
		private string _strSexo;

		public string Sexo
		{
			get { return _strSexo; }
			set { _strSexo = value; }
		}
		private int _intEdad;

		public int Edad
		{
			get { return _intEdad; }
			set { _intEdad = value; }
		}
		private double _dblCostoCosnultaGeneral;

		public double CostoConsultaGeneral
		{
			get { return _dblCostoCosnultaGeneral; }
			set { _dblCostoCosnultaGeneral = value; }
		}
		private double _dblCostoTratamiento;

		public double CostoTratamiento
		{
			get { return _dblCostoTratamiento; }
			set { _dblCostoTratamiento = value; }
		}

		public abstract double CalcularPago();

		public abstract string PagarMenos(PacienteTraumatologia P);
		
	}
}
