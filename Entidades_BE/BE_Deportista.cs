using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public abstract class BE_Deportista : Entidad
    {
        #region "Propiedades"
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public BE_Entrenador Entrenador { get; set; }
        #endregion
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.Apellido))
            {
                return this.Apellido.ToString();
            }
            return "";
        }
    }
}
