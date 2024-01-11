using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_BE
{
    public abstract class BEPersona : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int Edad { get; set; }
        public BEPersona()
        {

        }
        #region Metodo propio
        public int CalcularEdad()
        {
            Edad = DateTime.Now.Year - FechaNac.Year;

            if(DateTime.Now.Month < FechaNac.Month)
            {
                Edad--;
            }
            if(DateTime.Now.Month == FechaNac.Month && DateTime.Now.Day < FechaNac.Day)
            {
                Edad--;
            }

            return Edad;
        }
        #endregion
    }
}
