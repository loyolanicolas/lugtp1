using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_BE
{
    public class BE_Rutina : Entidad
    {
        public BE_Rutina()
        {
            lista_ejercicios = new List<BE_Ejercicio>();
        }
        public string Descripcion { get; set; }
        public BE_Deportista Deportista { get; set; }
        List<BE_Ejercicio> lista_ejercicios;

        public void AsociarEjercicio(BE_Ejercicio oBEEjer)
        {
            this.lista_ejercicios.Add(oBEEjer);
        }
        public List<BE_Ejercicio> RetornaEjercicios()
        {
            return lista_ejercicios;
        }
    }
}
