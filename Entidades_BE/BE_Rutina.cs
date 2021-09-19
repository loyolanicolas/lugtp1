using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public class BE_Rutina : Entidad
    {
        public string Descripcion { get; set; }
        public BE_Deportista Deportista { get; set; }
        List<BE_Ejercicio> lista_ejercicios;
    }
}
