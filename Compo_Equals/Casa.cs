using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compo_Equals
{
    class Casa
    {
        

        // Atributo (lista de componentes del Todo)
        private List<Cuarto> ListaDeCuartos = new List<Cuarto>();
        // Método para insertar una parte a la lista
        public void InsertarCuarto(Cuarto c)
        {
            ListaDeCuartos.Add(c);
        }
        // Destructor (elimina el componente)
        ~Casa()
        {
            ListaDeCuartos.Clear();
        }
        public IEnumerator<Cuarto> GetEnumerator()
        {
            foreach (Cuarto p in ListaDeCuartos)
                yield return p;
        }
        public void Eliminar(Cuarto c)
        {
           
            ListaDeCuartos.Remove(c);
               
        }
    }
}
