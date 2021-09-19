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
    public class BLL_Entrenador : I_Gestionable<BE_Entrenador>
    {
        MPP_Entrenador o_MPP_Entrenador;
        public BLL_Entrenador()
        {
            o_MPP_Entrenador = new MPP_Entrenador();
        }
        public bool Borrar(BE_Entrenador oBEEntr)//LISTO
        {
            if (TieneDeportistasAsociados(oBEEntr) == false)
            {
                return o_MPP_Entrenador.Borrar(oBEEntr);
            }
            else
            { return false; }
        }

        private bool TieneDeportistasAsociados(BE_Entrenador oBEEntrenador)//LISTO
        {
            return o_MPP_Entrenador.TieneDeportistasAsociados(oBEEntrenador);
        }

        public bool Guardar(BE_Entrenador oBEEntr)
        {
            return o_MPP_Entrenador.Guardar(oBEEntr);
        }

        public List<BE_Entrenador> ListarTodos()//LISTO
        {
            return o_MPP_Entrenador.ListarTodos();
        }

        public BE_Entrenador ListarUno(BE_Entrenador oBEEntr)
        {
            return o_MPP_Entrenador.ListarUno(oBEEntr);
        }
    }
}
