using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public class BE_Entrenador : Entidad
    {
        #region "Propiedades"
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion
        List<BE_Deportista> lista_deportistas;

    }
}
