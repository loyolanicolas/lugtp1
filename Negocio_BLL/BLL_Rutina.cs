using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using Entidades_BE;
using MPP;

namespace Negocio_BLL
{
    public class BLL_Rutina : I_Gestionable<BE_Rutina>
    {
        MPP_Rutina o_MPP_Rutina;
        public BLL_Rutina()
        {
            o_MPP_Rutina = new MPP_Rutina();
        }

        public bool Alta(BE_Rutina oBERut)
        {
            //if (VerificaExistencia(oBERut) == false)
                return o_MPP_Rutina.Alta(oBERut);
            //return false;
        }

        public bool Borrar(BE_Rutina oBERut)
        {
            //if (TieneEjerciciosAsociados(oBERut) == false)
            //{
                return o_MPP_Rutina.Borrar(oBERut);
            //}
            //else
            //{ return false; }
        }

        public bool Guardar(BE_Rutina oBERut)
        {
            return o_MPP_Rutina.Guardar(oBERut);
        }

        public List<BE_Rutina> ListarTodos()
        {
            return o_MPP_Rutina.ListarTodos();
        }

        public BE_Rutina ListarUno(BE_Rutina oBERut)
        {
            return o_MPP_Rutina.ListarUno(oBERut);
        }

        public string Test()
        {
            return o_MPP_Rutina.Test();
        }

        public void TraerEjercicios(BE_Rutina oBERut)
        {
            o_MPP_Rutina.TraerEjercicios(oBERut);
        }
    }
}
