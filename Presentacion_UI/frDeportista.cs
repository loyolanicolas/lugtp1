using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Necesito usar BE y BLL
using Entidades_BE;
using Negocio_BLL;

namespace Presentacion_UI
{
    public partial class frDeportista : Form
    {
        //BE_Profesional o_BE_Profesional;
        BLL_Deportista o_BLL_Deportista;
        public frDeportista()
        {
            InitializeComponent();
            //INSTANCIO LOS OBJETOS
            //o_BE_Profesional = new BE_Profesional();
            o_BLL_Deportista = new BLL_Deportista();
        }

        private void frDeportista_Load(object sender, EventArgs e)
        {
            CargardataGridView1();
        }
        private void CargardataGridView1()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = o_BLL_Deportista.ListarTodos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void btn_Agregar_Entrenador_Click(object sender, EventArgs e)
        {

        }

        private void btn_Borrar_Entrenador_Click(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Entrenador_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Asociar_Entrenador_Click(object sender, EventArgs e)
        {

        }
    }
}
