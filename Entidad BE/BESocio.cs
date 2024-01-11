using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_BE
{
    public class BESocio : BEPersona
    {
        public string Pago { get; set; }

        public List<BEActividad> listaActividades = new List<BEActividad>();
        public BESocio()
        {

        }
    }
}
