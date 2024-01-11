using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad_BE;

namespace Negocio_BLL
{
    public abstract class BLLPersona 
    {
        #region Metodos de negocio
        public virtual string ImprimirPersona(BESocio unSocio, BEProfesor unProfesor)
        {
            return "";
        }

        public abstract int CalcularCuota(BESocio unSocio);

        #endregion
    }
}
