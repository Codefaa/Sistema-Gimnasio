using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad_BE;
using Mapper_MPP;
using Abstraccion;

namespace Negocio_BLL
{
    public class BLLActividad : IGestor<BEActividad>
    {
        #region Constructor
        public BLLActividad()
        {
            MPPunaActividad = new MPPActividad();
        }

        MPPActividad MPPunaActividad;
        #endregion
        public List<BEActividad> ListarTodo()
        {
            return MPPunaActividad.ListarTodo();
        }
        public bool Guardar(BEActividad unaActividad)
        {
            return MPPunaActividad.Guardar(unaActividad);
        }
        public bool Baja(BEActividad unaActividad)
        {
            return MPPunaActividad.Baja(unaActividad);
        }
        public bool ActividadAsociada(BEActividad unaActividad)
        {
            return MPPunaActividad.ActividadAsociada(unaActividad);
        }
        public int ContadorActividades()
        {
            return MPPunaActividad.ContadorActividades();
        }
    }
}
