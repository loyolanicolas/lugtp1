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
    public class MPP_Deportista : I_Gestionable<BE_Deportista>
    {
        Acceso dal;
        public MPP_Deportista()
        {
            dal = new Acceso();
        }
        public bool Borrar(BE_Deportista Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Deportista Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_Deportista> ListarTodos()
        {
            List<BE_Deportista> ListaDeportistas = new List<BE_Deportista>();
            SqlDataReader unDR = dal.ListarTodos("Select * from deportista");
            while (unDR.Read())
            {
                //BE_Deportista unDeportista = new BE_Deportista();
                //unDeportista.Codigo = Convert.ToInt32(unDR[0]);
                //unDeportista.Nombre = unDR[1].ToString();
                //unDeportista.Apellido = unDR[2].ToString();
                //ListaDeportistas.Add(unDeportista);
            }
            //Cierro la conexion del SqlDataReader
            unDR.Close();
            dal.Cerrar();
            return ListaDeportistas;
        }

        public BE_Deportista ListarUno(BE_Deportista Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
