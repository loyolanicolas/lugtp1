using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_BE;
using Abstraccion;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace MPP
{
    public class MPP_Ejercicio : I_Gestionable<BE_Ejercicio>
    {
        Acceso dal;
        public MPP_Ejercicio()
        {
            dal = new Acceso();
        }
        public bool Borrar(BE_Ejercicio Objeto)
        {
            throw new NotImplementedException();
        }
        public bool Alta(BE_Ejercicio oBEEjer)
        {
            //instancio un objeto de la clase datos para operar con la BD
            string Consulta_SQL = string.Empty;
            //Consulta_SQL = "Update Entrenador SET Legajo = '" + oBEEntrenador.Codigo + "', Nombre = '" + oBEEntrenador.Nombre + "', Apellido = '" + oBEEntrenador.Apellido + "' where Legajo = '" + oBEEntrenador.Codigo + "'";
            //else
            Consulta_SQL = "Insert into Ejercicio (Id_ejercicio, Detalle) values(" + oBEEjer.Codigo + ", '" + oBEEjer.Detalle + "') ";
            //oDatos = new Acceso();
            return dal.Escribir(Consulta_SQL);
        }

        public bool Guardar(BE_Ejercicio oBEEjer)
        {
            //instancio un objeto de la clase datos para operar con la BD
            string Consulta_SQL = string.Empty;
            if (oBEEjer.Codigo != 0)
                Consulta_SQL = "Update ejercicio SET Id_ejercicio = '" + oBEEjer.Codigo + "', Detalle = '" + oBEEjer.Detalle + "' where Id_ejercicio = '" + oBEEjer.Codigo + "'";
            //else
                //Consulta_SQL = "Insert into Alumno (Nombre, Apellido,DNI, FechaNac,CodLocalidad) values('" + oBEAlu.Nombre + "', '" + oBEAlu.Apellido + "', " + oBEAlu.DNI + ",'" + (oBEAlu.FechaNac).ToString("MM/dd/yyyy") + "'," + oBEAlu.oBELocalidad.Codigo + ") ";
            //oDatos = new Acceso();
            return dal.Escribir(Consulta_SQL);
        }

        public bool VerificaExistencia(BE_Ejercicio oBEEjer)
        {
            string Consulta_SQL = string.Empty;
            Consulta_SQL = "Select count(Id_ejercicio) from Ejercicio where Id_ejercicio = " + oBEEjer.Codigo + "";
            return dal.Escribir(Consulta_SQL);
        }

        public List<BE_Ejercicio> ListarTodos()
        {
            List<BE_Ejercicio> ListaEjercicio = new List<BE_Ejercicio>();
            SqlDataReader unDR = dal.ListarTodos("Select * from ejercicio");
            while (unDR.Read())
            {
                BE_Ejercicio unEjercicio = new BE_Ejercicio();
                unEjercicio.Codigo = Convert.ToInt32(unDR[0]);
                unEjercicio.Detalle = unDR[1].ToString();
                ListaEjercicio.Add(unEjercicio);
            }
            //Cierro la conexion del SqlDataReader
            unDR.Close();
            dal.Cerrar();
            return ListaEjercicio;
        }

        public BE_Ejercicio ListarUno(BE_Ejercicio Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
