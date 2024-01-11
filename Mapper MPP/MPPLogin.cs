using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad_BE;
using System.Data;
using DAL;
using System.Collections;

namespace Mapper_MPP
{
    public class MPPLogin
    {
        public int Logear(BELogin unLogin)
        {
            DataTable table = new DataTable();

            Acceso acceso = new Acceso();

            Hashtable Hdatos = new Hashtable();

            string consulta = "S_Login_Logear";

            Hdatos.Add("@Usuario", unLogin.Usuario);
            Hdatos.Add("@Contraseña", unLogin.Contraseña);

            table = acceso.Leer(consulta, Hdatos);

            if (table.Rows.Count > 0)
            {
                return 1;
            }
            return -1;
        }
    }
}
