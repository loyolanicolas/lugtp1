using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_BE;
using Negocio_BLL;

namespace Presentacion_UI
{
    public partial class Login : Form
    {
        //BE_Usuario o_BE_Usuario;
        BLL_Login o_BLL_Login;
        public Login()
        {
            InitializeComponent();
            o_BLL_Login = new BLL_Login();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Usuario: usuario1
            //Contraseña: 123456
            if (o_BLL_Login.Loguear(textbox_Usuario_Login.Text, o_BLL_Login.Encriptar(o_BLL_Login.AplicarHash(textbox_Contraseña_Login.Text))))
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Usuario o Contraseña incorrecto");
        }

        private void btnSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
