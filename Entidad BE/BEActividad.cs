using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_BE
{
    public class BEActividad : Entidad
    {
        public string Deporte { get; set; }
        public int Precio { get; set; }
        public string Turno { get; set; }
        public BEProfesor unProfesor { get; set; }
        public BEActividad()
        {

        }
        public BEActividad(int codigo, string deporte, int precio, string turno, BEProfesor profe)
        {
            this.Codigo = codigo;
            this.Deporte = deporte;
            this.Precio = precio;
            this.Turno = turno;
            this.unProfesor = profe;
        }
    }
}
