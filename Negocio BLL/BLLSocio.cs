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
    public class BLLSocio : BLLPersona, IGestor<BESocio>
    {
        #region Constructor
        public BLLSocio()
        {
            MPPunSocio = new MPPSocio();
        }
        MPPSocio MPPunSocio;
        #endregion

        #region Metodos de negocio
        public override string ImprimirPersona(BESocio unSocio, BEProfesor unProfesor)
        {
            return $"{unSocio.Nombre} {unSocio.Apellido} {unSocio.Edad} años. Paga en {unSocio.Pago}";
        }
        public override int CalcularCuota(BESocio unSocio)
        {
            int cuota = 0;

            if(unSocio.listaActividades != null)
            {
                foreach (BEActividad item in unSocio.listaActividades)
                {
                    cuota += item.Precio;
                }
            }
            else
            {
                cuota = 0;
            }

            return cuota;
        }
        #endregion

        public List<BESocio> ListarTodo()
        {
           return MPPunSocio.ListarTodo();
        }
        public List<BEActividad> ActividadSocio(BESocio unSocio)
        {
            return MPPunSocio.ActividadSocio(unSocio);
        }
        public bool Guardar(BESocio unSocio)
        {
            return MPPunSocio.Guardar(unSocio);
        }
        public bool Baja(BESocio unSocio)
        {
            return MPPunSocio.Baja(unSocio);
        }
        public bool AgregarActividad(BESocio unSocio, BEActividad unaActividad)
        {
            return MPPunSocio.AgregarActividad(unSocio, unaActividad);
        }
        public bool QuitarActividad(BESocio unSocio, BEActividad unaActividad)
        {
            return MPPunSocio.QuitarActividad(unSocio, unaActividad);
        }
        public List<BESocio> BuscarSocio(BESocio unSocio)
        {
            return MPPunSocio.BuscarSocio(unSocio);
        }
        public int ContadorSocios()
        {
            return MPPunSocio.ContadorSocios();
        }
    }
}
