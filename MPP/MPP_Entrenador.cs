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
    public class MPP_Entrenador : I_Gestionable<BE_Entrenador>
    {
        Acceso dal;
        public MPP_Entrenador()
        {
            dal = new Acceso();
        }
        public bool Borrar(BE_Entrenador Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Entrenador oBEEntrenador)
        {
            //instancio un objeto de la clase datos para operar con la BD
            string Consulta_SQL = string.Empty;
            if (oBEEntrenador.Codigo != 0)
                Consulta_SQL = "Update Entrenador SET Legajo = '" + oBEEntrenador.Codigo + "', Nombre = '" + oBEEntrenador.Nombre + "', Apellido = '" + oBEEntrenador.Apellido + "' where Legajo = '" + oBEEntrenador.Codigo + "'";
            //else
                //Consulta_SQL = "Insert into Alumno (Nombre, Apellido,DNI, FechaNac,CodLocalidad) values('" + oBEAlu.Nombre + "', '" + oBEAlu.Apellido + "', " + oBEAlu.DNI + ",'" + (oBEAlu.FechaNac).ToString("MM/dd/yyyy") + "'," + oBEAlu.oBELocalidad.Codigo + ") ";
            //oDatos = new Acceso();
            return dal.Escribir(Consulta_SQL);
            }

        public List<BE_Entrenador> ListarTodos()
        {
            List<BE_Entrenador> ListaEntrenador = new List<BE_Entrenador>();
            SqlDataReader unDR = dal.ListarTodos("Select * from entrenador");
            while (unDR.Read())
            {
                BE_Entrenador unEntrenador = new BE_Entrenador();
                unEntrenador.Codigo = Convert.ToInt32(unDR[0]);
                unEntrenador.Nombre = unDR[1].ToString();
                unEntrenador.Apellido = unDR[2].ToString();
                ListaEntrenador.Add(unEntrenador);
            }
            //Cierro la conexion del SqlDataReader
            unDR.Close();
            dal.Cerrar();
            return ListaEntrenador;
        }

        public BE_Entrenador ListarUno(BE_Entrenador Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
