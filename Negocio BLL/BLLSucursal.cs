using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad_BE;
using Mapper_MPP;

namespace Negocio_BLL
{
    public class BLLSucursal
    {
        public BLLSucursal()
        {
            MPPunaSucursal = new MPPSucursal();
        }
        MPPSucursal MPPunaSucursal;

        public List<BESucursal> LeerXML()
        {
            return MPPunaSucursal.LeerXML();
        }
        public void AgregarXML(BESucursal unaSucursal)
        {
            MPPunaSucursal.AgregarXML(unaSucursal);
        }
        public void ModificarXML(BESucursal unaSucursal)
        {
            MPPunaSucursal.ModificarXML(unaSucursal);
        }
        public void BorrarXML(BESucursal unaSucursal)
        {
            MPPunaSucursal.BorrarXML(unaSucursal);
        }
        public List<BESucursal> BuscarXML(string direccion)
        {
            return MPPunaSucursal.BuscarXML(direccion);
        }
    }
}
