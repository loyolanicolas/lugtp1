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
    public class BLL_Deportista : I_Gestionable<BE_Deportista>
    {
        MPP_Deportista o_MPP_Deportista;
        public BLL_Deportista()
        {
            o_MPP_Deportista = new MPP_Deportista();
        }
        public bool Borrar(BE_Deportista oBEDepor)
        {
            return o_MPP_Deportista.Borrar(oBEDepor);
        }

        public bool Guardar(BE_Deportista oBEDepor)
        {
            return o_MPP_Deportista.Guardar(oBEDepor);
        }

        public List<BE_Deportista> ListarTodos()
        {
            return o_MPP_Deportista.ListarTodos();
        }

        public BE_Deportista ListarUno(BE_Deportista oBEDepor)
        {
            return o_MPP_Deportista.ListarUno(oBEDepor);
        }
    }
}
