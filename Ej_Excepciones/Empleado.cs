using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_Excepciones
{
    class Empleado
    {
        private int _intNumero;
        private string _strNombre;
        private int _intEdad;

        public int Numero
        {
            get { return _intNumero; }
            set
            {
                _intNumero = value;
                if (_intNumero <= 0)
                    throw new Exception("Dato incorrecto para  el número");
            }
        }
        public string Nombre
        {
            get { return _strNombre; }
            set
            {
                _strNombre = value;
                if (_strNombre == "")
                    throw new Exception("No debe dejar en blanco el nombre");
                foreach (char letra in _strNombre)
                {
                    // Caracteres permitidos
                    switch (letra)
                    {
                        case 'Á': continue;
                        case 'É': continue;
                        case 'Í': continue;
                        case 'Ó': continue;
                        case 'Ú': continue;
                        case 'Ñ': continue;
                        case 'Ü': continue;
                        case ' ': continue;
                    }
                    if (letra < 'A' || letra > 'Z')
                        throw new Exception("Solamente se permiten mayúsculas en el nombre (no capturar números ni otros caracteres)");
                }
            }
        }
        public int Edad
        {
            get { return _intEdad; }
            set
            {
                _intEdad = value;
                if (_intEdad < 0 || _intEdad > 110)
                    throw new Exception("Dato fuera de rango en la edad");
            }
        }
    }
}
