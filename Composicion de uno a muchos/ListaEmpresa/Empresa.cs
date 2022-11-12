using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEmpresa
{
    class Empresa
    {
        public Empresa(string a,string b,string c)
        {
            RFC = a;
            RazonSocial = b;
            Gerente = c;
        }
        private string _strRFC;

        public string RFC
        {
            get { return _strRFC; }
            set { _strRFC = value; }
        }
        private string _strRazonSocial;

        public string RazonSocial
        {
            get { return _strRazonSocial; }
            set { _strRazonSocial = value; }
        }
        private string _strGerente;

        public string Gerente
        {
            get { return _strGerente; }
            set { _strGerente = value; }
        }

        // Atributo (lista de componentes del Todo)
        private List<Departamento> ListaDepartamentos = new List<Departamento>();
        // Método para insertar una parte a la lista
        public void InsertarDepartamento(Departamento nuevoDepa)
        {
            ListaDepartamentos.Add(nuevoDepa);
        }
        // Destructor (elimina el componente)
        ~Empresa()
        {
            ListaDepartamentos.Clear();
        }
        public IEnumerator<Departamento> GetEnumerator()
        {
            foreach (Departamento p in ListaDepartamentos)
                yield return p;
        }



    }
}
