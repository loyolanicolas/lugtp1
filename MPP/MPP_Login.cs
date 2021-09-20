using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace MPP
{
    public class MPP_Login
    {
        Acceso dal;
        public MPP_Login()
        {
            dal = new Acceso();
        }

        public bool Loguear(string oBEUsuario, string oBEPassEncriptado)
        {
            return dal.LeerScalar("select count(IdUsuario) from Usuario where NombreUsuario = '" + oBEUsuario + "' and Pass = '" + oBEPassEncriptado + "'");
        }

    }
}
