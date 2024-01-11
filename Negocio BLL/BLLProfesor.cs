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
    public class BLLProfesor : BLLPersona, IGestor<BEProfesor>
    {
        #region Constructor
        public BLLProfesor()
        {
            MPPunProfesor = new MPPProfesor();
        }
        MPPProfesor MPPunProfesor;
        #endregion

        #region Metodos de negocio
        public override string ImprimirPersona(BESocio unSocio, BEProfesor unProfesor)
        {
            return $"{unProfesor.Nombre} {unProfesor.Apellido} {unProfesor.Edad} años. Tiene un sueldo de {unProfesor.Sueldo}";
        }
        public override int CalcularCuota(BESocio unSocio)
        {
            throw new NotImplementedException();
        }
        #endregion

        public List<BEProfesor> ListarTodo()
        {
            return MPPunProfesor.ListarTodo();
        }
        public bool Guardar(BEProfesor unProfesor)
        {
            return MPPunProfesor.Guardar(unProfesor);
        }
        public bool Baja(BEProfesor unProfesor)
        {
            return MPPunProfesor.Baja(unProfesor);
        }
        public bool ProfesorAsociado(BEProfesor unProfesor)
        {
            return MPPunProfesor.ProfesorAsociado(unProfesor);
        }
        public int ContadorProfesores()
        {
            return MPPunProfesor.ContadorProfesores();
        }
    }
}
