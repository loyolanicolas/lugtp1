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
    public class MPP_Rutina : I_Gestionable<BE_Rutina>
    {
        Acceso dal;
        public MPP_Rutina()
        {
            dal = new Acceso();
        }

        public bool Alta(BE_Rutina oBERut)
        {
            string ConsultaSQL = string.Empty;
            ConsultaSQL = "insert into Rutina (Descripcion, Deportista_NroSocio) values ('" + oBERut.Descripcion + "', ' 1 ')";
            return dal.Escribir(ConsultaSQL);
        }

        public bool Borrar(BE_Rutina oBERut)
        {
            //if (Existe_Materia_Asociada(oBEMat) == false)
            //{
            string Consulta_SQL = "DELETE FROM Rutina where Cod_Rutina = " + oBERut.Codigo + "";
            return dal.Escribir(Consulta_SQL);
            //}
            //else
            //{ return false; }
            //return false;
        }

        public bool Guardar(BE_Rutina oBERut)
        {
            //instancio un objeto de la clase datos para operar con la BD
            string Consulta_SQL = string.Empty;
            Consulta_SQL = "Update Rutina SET Descripcion = '" + oBERut.Descripcion + "' where Cod_Rutina = '" + oBERut.Codigo + "'";
            return dal.Escribir(Consulta_SQL);

        }

        public void TraerEjercicios(BE_Rutina oBERut)
        {
            SqlDataReader unDR = dal.ListarTodos("Select ej.Id_ejercicio, ej.Detalle from Ejercicio ej inner join Rutina_Ejercicio re on ej.Id_ejercicio = re.Id_Ejercicio where re.Cod_Rutina = " + oBERut.Codigo);
            while (unDR.Read())
            {
                BE_Ejercicio unEjercicio = new BE_Ejercicio();
                unEjercicio.Codigo = Convert.ToInt32(unDR[0]);
                unEjercicio.Detalle = unDR[1].ToString();
                oBERut.AsociarEjercicio(unEjercicio);
            }
            //cierro la conexion del datareader
            unDR.Close();
            dal.Cerrar();
        }

        public List<BE_Rutina> ListarTodos()
        {
            List<BE_Rutina> ListaRutinas = new List<BE_Rutina>();
            SqlDataReader unDR = dal.ListarTodos("Select * from Rutina ru inner join Deportista de on ru.Deportista_NroSocio = de.NroSocio");
            while (unDR.Read())
            {
                BE_Rutina unaRutina = new BE_Rutina();
                unaRutina.Codigo = Convert.ToInt32(unDR[0]);
                unaRutina.Descripcion = unDR[1].ToString();
                if (!string.IsNullOrEmpty(unDR["Medallas"].ToString()))
                {
                    unaRutina.Deportista = new BE_Profesional();
                    (unaRutina.Deportista as BE_Profesional).Medallas = Convert.ToInt32(unDR["Medallas"]);
                }
                else
                    unaRutina.Deportista = new BE_Aficionado();
                unaRutina.Deportista.Nombre = unDR["Nombre"].ToString();
                unaRutina.Deportista.Apellido = unDR["Apellido"].ToString();
                ListaRutinas.Add(unaRutina);
            }
            //cierro la conexion del datareader
            unDR.Close();
            dal.Cerrar();
            return ListaRutinas;
            
        }

        public BE_Rutina ListarUno(BE_Rutina Objeto)
        {
            throw new NotImplementedException();
        }

        public string Test()
        {
            return dal.TestConnection();
        }
    }
}