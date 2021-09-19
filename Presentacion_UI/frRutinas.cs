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
    public partial class frRutinas : Form
    {
        BE_Rutina o_BE_Rutina;
        BLL_Rutina o_BLL_Rutina;
        public frRutinas()
        {
            InitializeComponent();
            o_BE_Rutina = new BE_Rutina();
            o_BLL_Rutina = new BLL_Rutina();
        }

        private void frRutinas_Load(object sender, EventArgs e)
        {
            CargardataGridView1();
        }
        private void CargardataGridView1()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = o_BLL_Rutina.ListarTodos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }
    }
}
