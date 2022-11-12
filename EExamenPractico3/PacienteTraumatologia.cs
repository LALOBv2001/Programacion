using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamenPractico3
{
    class PacienteTraumatologia:Paciente
    {
	
		public override double CalcularPago()
		{
			if (this.Sexo == "FEMENINO" && this.Padecimiento == "ARTRITIS")
			{
				return (CostoConsultaGeneral + CostoTratamiento + 350);
			}
			else
			{
				return (CostoConsultaGeneral + CostoTratamiento);
			}
		}

		public override string PagarMenos(PacienteTraumatologia P)
		{
			if (this.CalcularPago() < P.CalcularPago())
			{
				return (this.Nombre);
			}
			else
			{
				return (P.Nombre);
			}
		}
		private string _strPadecimiento;

		public string Padecimiento
		{
			get { return _strPadecimiento; }
			set { _strPadecimiento = value; }
		}


	}
}
