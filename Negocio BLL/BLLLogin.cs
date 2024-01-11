using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad_BE;
using Mapper_MPP;

namespace Negocio_BLL
{
    public class BLLLogin
    {
        public BLLLogin()
        {
            MPPunLogin = new MPPLogin();
        }

        MPPLogin MPPunLogin;

        public int Logear(BELogin unLogin)
        {
            return MPPunLogin.Logear(unLogin);
        }
    }
}
