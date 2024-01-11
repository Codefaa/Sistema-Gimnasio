using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad_BE;
using DAL;
using System.Data;
using Abstraccion;
using System.Collections;

namespace Mapper_MPP
{
    public class MPPProfesor : IGestor<BEProfesor>
    {
        public List<BEProfesor> ListarTodo()
        {
            List<BEProfesor> listaProfesores = new List<BEProfesor>();

            DataTable table = new DataTable();

            Acceso acceso = new Acceso();

            string consulta = "S_Profesor_ListarTodo";

            table = acceso.Leer(consulta, null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow fila in table.Rows)
                {
                    BEProfesor unProfesor = new BEProfesor();
                    unProfesor.Codigo = Convert.ToInt32(fila["ID_Profesor"]);
                    unProfesor.Nombre = fila["Nombre"].ToString();
                    unProfesor.Apellido = fila["Apellido"].ToString();
                    unProfesor.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    unProfesor.Edad = unProfesor.CalcularEdad();
                    unProfesor.Sueldo = Convert.ToInt32(fila["Sueldo"]);

                    listaProfesores.Add(unProfesor);
                }
            }
            else
            {
                listaProfesores = null;
            }

            return listaProfesores;
        }
        public bool Guardar(BEProfesor unProfesor)
        {
            string consulta = string.Empty;
            Hashtable Hdatos = new Hashtable();

            if (unProfesor.Codigo == 0)
            {
                consulta = "S_Profesor_Alta";
                Hdatos.Add("@Nombre", unProfesor.Nombre);
                Hdatos.Add("@Apellido", unProfesor.Apellido);
                Hdatos.Add("@FechaNac", unProfesor.FechaNac);
                Hdatos.Add("@Sueldo", unProfesor.Sueldo);
            }
            else
            {
                consulta = "S_Profesor_Modificar";
                Hdatos.Add("@CodProfesor", unProfesor.Codigo);
                Hdatos.Add("@Nombre", unProfesor.Nombre);
                Hdatos.Add("@Apellido", unProfesor.Apellido);
                Hdatos.Add("@FechaNac", unProfesor.FechaNac);
                Hdatos.Add("@Sueldo", unProfesor.Sueldo);
            }

            Acceso acceso = new Acceso();

            return acceso.Escritura(consulta, Hdatos);
        }
        public bool Baja(BEProfesor unProfesor)
        {
            Hashtable Hdatos = new Hashtable();

            if (ProfesorAsociado(unProfesor) == false)
            {
                string consulta = "S_Profesor_Baja";

                Hdatos.Add("@CodProfesor", unProfesor.Codigo);

                Acceso acceso = new Acceso();

                return acceso.Escritura(consulta, Hdatos);
            }
            else
            {
                return false;
            }
        }
        public bool ProfesorAsociado(BEProfesor unProfesor)
        {
            Hashtable Hdatos = new Hashtable();

            string consulta = "S_Profesor_Asociado";

            Hdatos.Add("@CodProfesor", unProfesor.Codigo);

            Acceso acceso = new Acceso();

            return acceso.LeerEscalar(consulta, Hdatos);
        }
        public int ContadorProfesores()
        {
            string consulta = "S_Profesor_Contador";

            Acceso acceso = new Acceso();

            int contador = Convert.ToInt32(acceso.Contador(consulta, null));

            return contador;
        }
    }
}
