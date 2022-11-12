using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3._4
{
    class EstantePelicula
    {
        private int _intNumeroRepisas;

        public int NumeroRepisas
        {
            get { return _intNumeroRepisas; }
            set { _intNumeroRepisas = value; }
        }
        private string _strColor;

        public string Color
        {
            get { return _strColor; }
            set { _strColor = value; }
        }
        public int SumarDiscos()
        {
             int intSuma = 0;
            foreach (EstuchePelicula miEstuchePelicula in ListaEstuches)
            {
                intSuma = intSuma + miEstuchePelicula.CantidadDiscos;
            }
            return (intSuma);
        }
        // Atributo (lista de componentes del Todo)
        private List<EstuchePelicula> ListaEstuches = new List<EstuchePelicula>();
        // Método para insertar una parte a la lista
        public void InsertarEstuche(EstuchePelicula e)
        {
            ListaEstuches.Add(e);
        }
        
        public IEnumerator<EstuchePelicula> GetEnumerator()
        {
            foreach (EstuchePelicula p in ListaEstuches)
                yield return p;
        }
    }
}
