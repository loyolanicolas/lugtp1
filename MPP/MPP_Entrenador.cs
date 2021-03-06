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
        public bool Borrar(BE_Entrenador oBEEntrenador)//LISTO
        {
            string Consulta_SQL = "DELETE FROM Entrenador where Legajo = " + oBEEntrenador.Codigo + "";
            return dal.Escribir(Consulta_SQL);
        }

        public bool TieneDeportistasAsociados(BE_Entrenador oBEEntrenador)//LISTO
        {
            return dal.LeerScalar("select count(Entrenador_Legajo) from Deportista where Entrenador_Legajo =" + oBEEntrenador.Codigo + "");
        }


        public bool Guardar(BE_Entrenador oBEEntrenador)
        {
            //instancio un objeto de la clase datos para operar con la BD
            string Consulta_SQL = string.Empty;
            Consulta_SQL = "Update Entrenador SET Legajo = '" + oBEEntrenador.Codigo + "', Nombre = '" + oBEEntrenador.Nombre + "', Apellido = '" + oBEEntrenador.Apellido + "' where Legajo = '" + oBEEntrenador.Codigo + "'";
            return dal.Escribir(Consulta_SQL);
        }

        public List<BE_Entrenador> ListarTodos()//LISTO
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

        public bool VerificaExistencia(BE_Entrenador oBEEntr)
        {
            return dal.LeerScalar("select count(Legajo) from Entrenador where Legajo =" + oBEEntr.Codigo + "");
        }

        public BE_Entrenador ListarUno(BE_Entrenador oBEEntr)
        {
            throw new NotImplementedException();
        }

        public bool Alta(BE_Entrenador oBEEntr)
        {
            string ConsultaSQL = string.Empty;
            ConsultaSQL = "insert into Entrenador values (" + oBEEntr.Codigo + ", '" + oBEEntr.Nombre + "', '" + oBEEntr.Apellido + "')";
            return dal.Escribir(ConsultaSQL);
        }
    }
}
