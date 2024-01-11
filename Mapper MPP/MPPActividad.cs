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
    public class MPPActividad : IGestor<BEActividad>
    {
        public List<BEActividad> ListarTodo()
        {
            List<BEActividad> listaActividades = new List<BEActividad>();

            DataTable table = new DataTable();

            Acceso acceso = new Acceso();

            string consulta = "S_Actividad_ListarTodo";

            table = acceso.Leer(consulta, null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow fila in table.Rows)
                {
                    BEActividad BEunaActividad = new BEActividad();
                    BEunaActividad.Codigo = Convert.ToInt32(fila["ID_Actividad"]);
                    BEunaActividad.Deporte = fila["Deporte"].ToString();
                    BEunaActividad.Precio = Convert.ToInt32(fila["Precio"]);
                    BEunaActividad.Turno = fila["Turno"].ToString();
                    BEProfesor BEunProfesor = new BEProfesor();
                    BEunProfesor.Codigo = Convert.ToInt32(fila["ID_Profesor"]);
                    BEunProfesor.Nombre = fila["Nombre"].ToString();
                    BEunProfesor.Apellido = fila["Apellido"].ToString();
                    BEunProfesor.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    BEunProfesor.Edad = BEunProfesor.CalcularEdad();
                    BEunProfesor.Sueldo = Convert.ToInt32(fila["Sueldo"]);
                    BEunaActividad.unProfesor = BEunProfesor;

                    listaActividades.Add(BEunaActividad);
                }
            }
            else
            {
                listaActividades = null;
            }

            return listaActividades;
        }
        public bool Guardar(BEActividad unaActividad)
        {
           Hashtable Hdatos = new Hashtable();
            string consulta = string.Empty;

            if (unaActividad.Codigo == 0)
            {
                consulta = "S_Actividad_Alta";
                Hdatos.Add("@Deporte", unaActividad.Deporte);
                Hdatos.Add("@Precio", unaActividad.Precio);
                Hdatos.Add("@Turno", unaActividad.Turno);
                Hdatos.Add("@CodProfesor", unaActividad.unProfesor.Codigo);
            }
            else
            {
                consulta = "S_Actividad_Modificar";
                Hdatos.Add("@CodActividad", unaActividad.Codigo);
                Hdatos.Add("@Deporte", unaActividad.Deporte);
                Hdatos.Add("@Precio", unaActividad.Precio);
                Hdatos.Add("@Turno", unaActividad.Turno);
                Hdatos.Add("@CodProfesor", unaActividad.unProfesor.Codigo);
            }

            Acceso acceso = new Acceso();

           return acceso.Escritura(consulta, Hdatos);
        }
        public bool Baja(BEActividad unaActividad)
        {
            Hashtable Hdatos = new Hashtable();

            if (ActividadAsociada(unaActividad) == false)
            {
                string consulta = "S_Actividad_Baja";

                Hdatos.Add("@CodActividad", unaActividad.Codigo);

                Acceso acceso = new Acceso();

                return acceso.Escritura(consulta, Hdatos);
            }
            else
            {
                return false;
            }
        }
        public bool ActividadAsociada(BEActividad unaActividad)
        {
            Hashtable Hdatos = new Hashtable(); 

            string consulta = "S_Actividad_Asociada";

            Hdatos.Add("@CodActividad", unaActividad.Codigo);

            Acceso acceso = new Acceso();

            return acceso.LeerEscalar(consulta, Hdatos);
        }
        public int ContadorActividades()
        {
            string consulta = "S_Actividad_Contador";

            Acceso acceso = new Acceso();

            int contador = Convert.ToInt32(acceso.Contador(consulta, null));

            return contador;
        }
    }
}
