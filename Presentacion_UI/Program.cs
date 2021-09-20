using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Menu());
            //Creo el form del login y pregunto si el resultado de DialogResult es OK (que lo coloco en ese estado si el login fue correcto) para que se cierre el form del login y se abra el principal al loguearse
            Login frm_Login_formulario = new Login();
            DialogResult Res = frm_Login_formulario.ShowDialog();
            if (Res == DialogResult.OK)
                Application.Run(new Menu());
        }
    }
}
