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
                //o_BE_Entrenador.DNI = Convert.ToInt32(textbox_DNI_Entrenador.Text);
                //llamo al metodo guardar de la bll alumno y le paso la BE de alumno
                //oBLLAlu.Guardar(oBEAlu);
                //CargarGrilla();
                //Limpiar();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
    
    }
}
