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

        public bool Guardar(BE_Ejercicio Objeto)
        {
            throw new NotImplementedException();
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
