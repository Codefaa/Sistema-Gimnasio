using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DAL
{
    public class Acceso
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-D1HGMQE\SQLEXPRESS;Initial Catalog=TP LUG;Integrated Security=True");
        public DataTable Leer(string consulta, Hashtable Hdatos)
        {
            conexion.Open();

            DataTable table = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = consulta;

            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                if(Hdatos != null) 
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        comando.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                } 

                adaptador.Fill(table);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return table;
        }
        public bool Escritura(string consulta, Hashtable Hdatos)
        {
            conexion.Open();

            SqlTransaction transaccion;
            transaccion = conexion.BeginTransaction();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.Transaction = transaccion;
            comando.CommandType = CommandType.StoredProcedure;  
            comando.CommandText = consulta;

            comando.Transaction = transaccion;
            transaccion.Commit();

            try
            {
                if(Hdatos != null) 
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        comando.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }   

                int respuesta = comando.ExecuteNonQuery();
                return true;
            }
            catch(SqlException ex)
            {
                transaccion.Rollback();
                throw ex;
            }
            catch(Exception ex)
            {
                transaccion.Rollback();
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool LeerEscalar(string consulta, Hashtable Hdatos)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure; 
            comando.CommandText = consulta;

            try
            {
                if(Hdatos != null)  
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        comando.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }  

                int respuesta = Convert.ToInt32(comando.ExecuteScalar());

                if(respuesta > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public int Contador(string consulta, Hashtable Hdatos)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure; 
            comando.CommandText = consulta;

            try
            {
                if(Hdatos != null)  
                {
                    foreach (string dato in Hdatos.Keys)
                    {
                        comando.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }   

                int contador = Convert.ToInt32(comando.ExecuteScalar());

                return contador;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}