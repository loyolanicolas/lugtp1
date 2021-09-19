using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public interface I_Gestionable <T> where T : I_Entidad
    {
        bool Alta(T Objeto);
        bool Guardar(T Objeto);
        bool Borrar(T Objeto);
        List<T> ListarTodos();
        T ListarUno(T Objeto);
    }
}
