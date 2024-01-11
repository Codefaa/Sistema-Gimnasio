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
    public class MPPSocio : IGestor<BESocio>
    {
        public List<BESocio> ListarTodo()
        {
            List<BESocio> listaSocios = new List<BESocio>();
            DataTable table = new DataTable();
            Acceso acceso = new Acceso();
            string consulta = "S_Socio_ListarTodo";

            table = acceso.Leer(consulta, null);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow fila in table.Rows)
                {
                    BESocio unSocio = new BESocio();
                    unSocio.Codigo = Convert.ToInt32(fila["ID_Socio"]);
                    unSocio.Nombre = fila["Nombre"].ToString();
                    unSocio.Apellido = fila["Apellido"].ToString();
                    unSocio.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    unSocio.Edad = unSocio.CalcularEdad();
                    unSocio.Pago = fila["Pago"].ToString();

                    unSocio.listaActividades = ActividadSocio(unSocio);

                    listaSocios.Add(unSocio);
                }
            }
            else
            {
                listaSocios = null;
            }

            return listaSocios;
        }

        public List<BEActividad> ActividadSocio(BESocio unSocio)
        {
            List<BEActividad> listaActividades = new List<BEActividad>();
            DataTable table = new DataTable();
            Hashtable Hdatos = new Hashtable();
            Acceso acceso = new Acceso();
            string consulta = "S_Socio_ActividadSocio";

            Hdatos.Add("@ID_Socio", unSocio.Codigo);

            table = acceso.Leer(consulta, Hdatos);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow fila in table.Rows)
                {
                    BEActividad unaActividad = new BEActividad();
                    unaActividad.Codigo = Convert.ToInt32(fila["ID_Actividad"]);
                    unaActividad.Deporte = fila["Deporte"].ToString();
                    unaActividad.Precio = Convert.ToInt32(fila["Precio"]);
                    unaActividad.Turno = fila["Turno"].ToString();
                    BEProfesor unProfesor = new BEProfesor();
                    unProfesor.Codigo = Convert.ToInt32(fila["ID_Profesor"]);
                    unProfesor.Nombre = fila["Nombre"].ToString();
                    unProfesor.Apellido = fila["Apellido"].ToString();
                    unProfesor.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    unProfesor.Edad = unProfesor.CalcularEdad();
                    unProfesor.Sueldo = Convert.ToInt32(fila["Sueldo"]);
                    unaActividad.unProfesor = unProfesor;

                    listaActividades.Add(unaActividad);
                }
            }
            else
            {
                listaActividades = null;
            }

            return listaActividades;
        }

        public bool Guardar(BESocio unSocio)
        {
            Hashtable Hdatos = new Hashtable();
            string consulta = string.Empty;

            if (unSocio.Codigo == 0)
            {
                consulta = "S_Socio_Alta";

                Hdatos.Add("@Nombre", unSocio.Nombre);
                Hdatos.Add("@Apellido", unSocio.Apellido);
                Hdatos.Add("@FechaNac", unSocio.FechaNac);
                Hdatos.Add("@Pago", unSocio.Pago);
            }
            else
            {
                consulta = "S_Socio_Modificar";

                Hdatos.Add("@CodSocio", unSocio.Codigo);
                Hdatos.Add("@Nombre", unSocio.Nombre);
                Hdatos.Add("@Apellido", unSocio.Apellido);
                Hdatos.Add("@FechaNac", unSocio.FechaNac);
                Hdatos.Add("@Pago", unSocio.Pago);
            }

            Acceso acceso = new Acceso();

            return acceso.Escritura(consulta, Hdatos);
        }

        public bool Baja(BESocio unSocio)
        {
            Hashtable Hdatos = new Hashtable();

            string consulta = "S_Socio_Baja";

            Hdatos.Add("@CodSocio", unSocio.Codigo);

            Acceso acceso = new Acceso();

            return acceso.Escritura(consulta, Hdatos);
        }

        public bool AgregarActividad(BESocio unSocio, BEActividad unaActividad)
        {
            Hashtable Hdatos = new Hashtable();

            string consulta = "S_Socio_AgregarActividad";

            Hdatos.Add("@CodSocio", unSocio.Codigo);
            Hdatos.Add("@CodActividad", unaActividad.Codigo);

            Acceso acceso = new Acceso();

            return acceso.Escritura(consulta, Hdatos);
        }

        public bool QuitarActividad(BESocio unSocio, BEActividad unaActividad)
        {
            Hashtable Hdatos = new Hashtable();

            string consulta = "S_Socio_QuitarActividad";

            Hdatos.Add("@CodSocio", unSocio.Codigo);
            Hdatos.Add("@CodActividad", unaActividad.Codigo);

            Acceso acceso = new Acceso();

            return acceso.Escritura(consulta, Hdatos);
        }

        public List<BESocio> BuscarSocio(BESocio unSocio)
        {
            List<BESocio> listaSocios = new List<BESocio>();
            DataTable table = new DataTable();
            Hashtable Hdatos = new Hashtable();
            Acceso acceso = new Acceso();
            string consulta = "S_Socio_BuscarSocio";

            Hdatos.Add("@Nombre", unSocio.Nombre);

            table = acceso.Leer(consulta, Hdatos);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow fila in table.Rows)
                {
                    unSocio.Codigo = Convert.ToInt32(fila["ID_Socio"]);
                    unSocio.Nombre = fila["Nombre"].ToString();
                    unSocio.Apellido = fila["Apellido"].ToString();
                    unSocio.FechaNac = Convert.ToDateTime(fila["FechaNac"]);
                    unSocio.Edad = unSocio.CalcularEdad();
                    unSocio.Pago = fila["Pago"].ToString();

                    unSocio.listaActividades = ActividadSocio(unSocio);

                    listaSocios.Add(unSocio);
                }
            }
            else
            {
                listaSocios = null;
            }

            return listaSocios;
        }

        public int ContadorSocios()
        {
            string consulta = "S_Socio_Contador";

            Acceso acceso = new Acceso();

            int contador = Convert.ToInt32(acceso.Contador(consulta, null));

            return contador;
        }
    }
}
