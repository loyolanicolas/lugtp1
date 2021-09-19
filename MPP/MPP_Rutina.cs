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
        public bool Borrar(BE_Rutina Objeto)
        {
            //if (Existe_Materia_Asociada(oBEMat) == false)
            //{
            string Consulta_SQL = "DELETE FROM Rutina where Cod_Rutina = " + Objeto.Codigo + "";
            return dal.Escribir(Consulta_SQL);
            //}
            //else
            //{ return false; }
            return false;
        }

        public bool Guardar(BE_Rutina Objeto)
        {
            try
            {
                //string Consulta_SQL;
                //if (oBEMat.Codigo != 0)
                //{
                //    Consulta_SQL = "update Materia SET Nombre = '" + oBEMat.Materia + "' where Codigo = " + oBEMat.Codigo + "";
                //}
                //else
                //{
                //    Consulta_SQL = "Insert into Materia (Nombre)values('" + oBEMat.Materia + "')";
                //}
                ////instancio un objeto de la clase datos para operar con la BD
                //oDatos = new Acceso();
                
                
                //dal.TransaccionIniciar();
                //int IdRutina = dal.Escribir(Consulta_SQL);
                //Consulta_SQL = "insert de un Item Where IdRutina = " + IdRutina;
                //dal.Escribir(Consulta_SQL);
                //dal.TransaccionAceptar();

                //return oDatos.Escribir(Consulta_SQL);

                return false;
            }
            catch (Exception)
            {
                //dal.TransaccionCancelar();
                throw;
            }
            
        }

        public List<BE_Rutina> ListarTodos()
        {
            List<BE_Rutina> ListaRutinas = new List<BE_Rutina>();
            SqlDataReader unDR = dal.ListarTodos("Select * from rutina");
            while (unDR.Read())
            {
                BE_Rutina unaRutina = new BE_Rutina();
                unaRutina.Codigo = Convert.ToInt32(unDR[0]);
                unaRutina.Descripcion = unDR[1].ToString();
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