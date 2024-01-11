using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_BE
{
    public class BEProfesor : BEPersona
    {
        public int Sueldo { get; set; }
        public BEProfesor()
        {

        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
