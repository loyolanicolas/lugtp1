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
    public partial class frEntrenador : Form
    {
        BE_Entrenador o_BE_Entrenador;
        BLL_Entrenador o_BLL_Entrenador;
        
        public frEntrenador()
        {
            InitializeComponent();
            //INSTANCIO LOS OBJETOS
            o_BE_Entrenador = new BE_Entrenador();
            o_BLL_Entrenador = new BLL_Entrenador();
        }

        private void frEntrenador_Load(object sender, EventArgs e)
        {
            CargardataGridView1();
        }

        private void CargardataGridView1()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = o_BLL_Entrenador.ListarTodos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

            private void btn_Agregar_Entrenador_Click(object sender, EventArgs e)
        {
            try
            {
                o_BE_Entrenador.Nombre = texbox_Nombre_Entrenador.Text;
                o_BE_Entrenador.Apellido = textbox_Apellido_Entrenador.Text;
                o_BE_Entrenador.Codigo = Convert.ToInt32(textbox_Legajo_Entrenador.Text);
                //llamo al metodo guardar de la bll Entrenador y le paso la BE de Entrenador
                if(o_BLL_Entrenador.Alta(o_BE_Entrenador) == false)
                    MessageBox.Show("Ya existe un Entrenador con Legajo Nro: " + o_BE_Entrenador.Codigo);
                CargardataGridView1();
                //Limpiar(); REVISAR SI HAY QUE HACERLA

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void btn_Borrar_Entrenador_Click(object sender, EventArgs e)
        {
            o_BE_Entrenador = (BE_Entrenador)this.dataGridView1.CurrentRow.DataBoundItem;
            if (o_BLL_Entrenador.Borrar(o_BE_Entrenador) == false)
                MessageBox.Show("El Entrenador " + o_BE_Entrenador.Nombre + " " + o_BE_Entrenador.Apellido + " tiene Deportistas asociados");
            CargardataGridView1();
        }

        private void btn_Modificar_Entrenador_Click(object sender, EventArgs e)
        {
            o_BE_Entrenador.Codigo = (this.dataGridView1.CurrentRow.DataBoundItem as BE_Entrenador).Codigo;
            o_BE_Entrenador.Nombre = texbox_Nombre_Entrenador.Text;
            o_BE_Entrenador.Apellido = textbox_Apellido_Entrenador.Text;
            //o_BE_Entrenador.Codigo = Convert.ToInt32(textbox_Legajo_Entrenador.Text);
            o_BLL_Entrenador.Guardar(o_BE_Entrenador);
            CargardataGridView1();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            o_BE_Entrenador = (BE_Entrenador)this.dataGridView1.CurrentRow.DataBoundItem;
            texbox_Nombre_Entrenador.Text = o_BE_Entrenador.Nombre;
            textbox_Apellido_Entrenador.Text = o_BE_Entrenador.Apellido;
            textbox_Legajo_Entrenador.Text = o_BE_Entrenador.Codigo.ToString();
        }
    }
}
