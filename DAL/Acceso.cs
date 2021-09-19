using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias de SQL
using System.Data;
using System.Data.SqlClient;
//Para poder usar App.Config
using System.Configuration;


namespace DAL
{
    public class Acceso
    {
        //Declaro un objeto de tipo "Conection" y a travéz del constructor sobrecargado le paso el ConectionString
        

        //Declaro la variable de tipo conection
        private SqlConnection conexion;
        //Para usar Transacciones después
        private SqlTransaction Transaccion;

        //Creo el metodo Abrir e instancio conexion.
        public void Abrir()
        {
            conexion = new SqlConnection();
            //Le paso al conectiostring la cadena que contiene los datos de la BD
            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["MiCadenaDeConexion"].ToString();
            //Verifico que conexion tenga datos y que la conexion esté cerrada. Entonces la abro.
            if (conexion != null && conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            
        }
        
        //Creo el metodo Cerrar la conexion y limpio la misma de memoria con el Dispose.
        public void Cerrar()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            //Una seguridad extra ejecutar el recolector.
            GC.Collect();
        }
        
        #region "Transacciones"
        public void TransaccionIniciar()
        {
            try
            {
                Transaccion = conexion.BeginTransaction();
            }
            catch (Exception es)
            {
                throw;
            }
        }

        public void TransaccionAceptar()
        {
            try
            {
                Transaccion.Commit();
            }
            catch (Exception es)
            {
                throw;
            }
        }


        public void TransaccionCancelar()
        {
            try
            {
                Transaccion.Rollback();
            }
            catch (Exception es)
            {
                throw;
            }
        }
        #endregion

        // creo una funcion para saber el estado de la conexion
        public string TestConnection()
        {
            try
            {
                Abrir();
                //si no uso el metodo Abrir puedo hacer el open 
                //conexion = new SqlConnection();
                // conexion.Open();
                //Cerrar();
                if (conexion.State == ConnectionState.Open)
                {
                    return "Conexion exitosa";

                }
                else
                {
                    return "Hubo algún error!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Cerrar();
            }
            
        }

        
        public SqlDataReader ListarTodos(string consulta)
        {
            try
            {
                Abrir();
                //Instancio el objeto command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                //Envio la consulta que llega por parámetro
                cmd.CommandText = consulta;
                cmd.Connection = conexion;
                //El objeto lector del tipo SqlDataReader
                SqlDataReader lector = cmd.ExecuteReader();
                //Retorno lector con los datos
                return lector;
            }
            catch (Exception es)
            {
                throw;
            }
            
            
            
        }


        ////leo un escalar-
        public bool LeerScalar(string consulta)
        {
            conexion.Open();
            //uso el constructor del objeto Command
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
        }


        ////realizo un método escribir generico, dado que recibo un string q es la consulta de SQL
        public bool Escribir(string Consulta_SQL)
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = Consulta_SQL;
            try
            {
                int respuesta = cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            { conexion.Close(); }
        }

    }
}
