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
                BE_Deportista unDeportista;
                if (unDR["Medallas"] != null)
                    unDeportista = new BE_Profesional();
                else
                    unDeportista = new BE_Aficionado();
                //(unDeportista as BE_Profesional).Medallas = 1;
                unDeportista.Codigo = Convert.ToInt32(unDR[0]);
                unDeportista.Nombre = unDR[1].ToString();
                unDeportista.Apellido = unDR[2].ToString();
                unDeportista.FechaNac = Convert.ToDateTime(unDR[3]);
                //if(unDeportista.GetType() == typeof(BE_Profesional))
                //    (unDeportista as BE_Profesional).Medallas = Convert.ToInt32(unDR[5]);
                ListaDeportistas.Add(unDeportista);
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
