using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Materia
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }

        public Materia()
        {
            Nombre = "materia nueva";
            Identificador = "0";
        }
        public Materia(string nombre, string id)
        {
            Identificador = id;
            Nombre = nombre;
        }
    }


}
