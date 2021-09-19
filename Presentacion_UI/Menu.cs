﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Negocio_BLL.BLL_Rutina aux = new Negocio_BLL.BLL_Rutina();
            MessageBox.Show(aux.Test());
            aux.ListarTodos();
        }

        private void entrenadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frEntrenador o_frEntrenador = new frEntrenador();
            o_frEntrenador.MdiParent = this;
            o_frEntrenador.Show();
        }
    }
}