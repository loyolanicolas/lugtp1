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
    public partial class frEjercicios : Form
    {
        BE_Ejercicio o_BE_Ejercicio;
        BLL_Ejercicio o_BLL_Ejercicio;
        public frEjercicios()
        {
            InitializeComponent();
            o_BE_Ejercicio = new BE_Ejercicio();
            o_BLL_Ejercicio = new BLL_Ejercicio();
        }

        private void frEjercicios_Load(object sender, EventArgs e)
        {
            CargardataGridView1();
        }

        private void CargardataGridView1()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = o_BLL_Ejercicio.ListarTodos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            o_BE_Ejercicio = (BE_Ejercicio)this.dataGridView1.CurrentRow.DataBoundItem;
            texbox_Detalle_Ejer.Text = o_BE_Ejercicio.Detalle;
            textBox1.Text = o_BE_Ejercicio.Codigo.ToString();
        }

        private void btn_Mod_Ejer_Click(object sender, EventArgs e)
        {
            try
            {
                o_BE_Ejercicio.Detalle = texbox_Detalle_Ejer.Text;
                o_BE_Ejercicio.Codigo = Convert.ToInt32(textBox1.Text);
                //llamo al metodo guardar de la bll Entrenador y le paso la BE de Entrenador
                o_BLL_Ejercicio.Guardar(o_BE_Ejercicio);
                CargardataGridView1();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_Alta_Ejer_Click(object sender, EventArgs e)
        {
            try
            {
                o_BE_Ejercicio.Detalle = texbox_Detalle_Ejer.Text;
                o_BE_Ejercicio.Codigo = Convert.ToInt32(textBox1.Text);
                //llamo al metodo guardar de la bll Entrenador y le paso la BE de Entrenador
                o_BLL_Ejercicio.Alta(o_BE_Ejercicio);
                CargardataGridView1();

                //if (o_BLL_Ejercicio.Alta(o_BE_Ejercicio) == false)
                //    MessageBox.Show("Ya existe un Ejercicio con ID Nro: " + o_BE_Ejercicio.Codigo);

                //Limpiar(); REVISAR SI HAY QUE HACERLA
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_Baja_Ejer_Click(object sender, EventArgs e)
        {
            o_BE_Ejercicio = (BE_Ejercicio)this.dataGridView1.CurrentRow.DataBoundItem;
            if (o_BLL_Ejercicio.Borrar(o_BE_Ejercicio) == false)
                MessageBox.Show("El Ejercicio " + o_BE_Ejercicio.Detalle + " tiene Rutinas asociadas");
            CargardataGridView1();
        }
    }
}
