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
    public class BLL_Ejercicio : I_Gestionable<BE_Ejercicio>
    {
        MPP_Ejercicio o_MPP_Ejercicio;
        public BLL_Ejercicio()
        {
            o_MPP_Ejercicio = new MPP_Ejercicio();
        }
        public bool Borrar(BE_Ejercicio oBEEjer)
        {
            return o_MPP_Ejercicio.Borrar(oBEEjer);
        }
        public bool Alta(BE_Ejercicio oBEEjer)
        {
            return o_MPP_Ejercicio.Alta(oBEEjer);
        }
        public bool Guardar(BE_Ejercicio oBEEjer)
        {
            //if(VerificaExistencia(oBEEjer))
            return o_MPP_Ejercicio.Guardar(oBEEjer);
        }

        private bool VerificaExistencia(BE_Ejercicio oBEEjer)
        {
            return o_MPP_Ejercicio.VerificaExistencia(oBEEjer);
        }

        public List<BE_Ejercicio> ListarTodos()
        {
            return o_MPP_Ejercicio.ListarTodos();
        }

        public BE_Ejercicio ListarUno(BE_Ejercicio oBEEjer)
        {
            return o_MPP_Ejercicio.ListarUno(oBEEjer);
        }
    }
}
