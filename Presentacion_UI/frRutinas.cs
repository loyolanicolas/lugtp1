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
        BLL_Deportista o_BLL_Deportista;
        BLL_Ejercicio o_BLL_Ejercicio;
        public frRutinas()
        {
            InitializeComponent();
            o_BE_Rutina = new BE_Rutina();
            o_BLL_Rutina = new BLL_Rutina();
            o_BLL_Deportista = new BLL_Deportista();
            o_BLL_Ejercicio = new BLL_Ejercicio();
        }

        private void frRutinas_Load(object sender, EventArgs e)
        {
            CargardataGridView1();
            comboBox1.DataSource = null;
            comboBox1.DataSource = o_BLL_Deportista.ListarTodos();
            comboBox1.ValueMember = "Codigo";
            //la variable publica de la clase
            comboBox1.DisplayMember = "Apellido";
            comboBox1.Refresh();
        }

        private void CargaComboBoxEjercicios()
        {
            comboBox2_Ejer.DataSource = null;
            comboBox2_Ejer.DataSource = o_BLL_Ejercicio.ListarTodos();
            comboBox2_Ejer.ValueMember = "Codigo";
            //la variable publica de la clase
            comboBox2_Ejer.DisplayMember = "Detalle";
            comboBox2_Ejer.Refresh();
        }

        //private void CargardataGridViewotro()
        //{
        //    this.dataGridView1.DataSource = null;
        //    this.dataGridView1.DataSource = o_BLL_Ejercicio.ListarTodos();
        //    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        //}

        private void CargardataGridView1()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = o_BLL_Rutina.ListarTodos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void btn_Agregar_Rut_Click(object sender, EventArgs e)
        {
            try
            {
                o_BE_Rutina.Descripcion = texbox_Descripcion_Rut.Text;
                o_BE_Rutina.Deportista = (BE_Deportista)this.comboBox1.SelectedItem;
                if (o_BLL_Rutina.Alta(o_BE_Rutina) == false)
                    MessageBox.Show("Ya existe una Rutina con Codigo Nro: " + o_BE_Rutina.Codigo);
                CargardataGridView1();
                //Limpiar(); REVISAR SI HAY QUE HACERLA

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_MOD_Rut_Click(object sender, EventArgs e)
        {
            o_BE_Rutina.Descripcion = texbox_Descripcion_Rut.Text;
            o_BE_Rutina.Codigo = Convert.ToInt32(textBox1_Codigo_Rut.Text);
            o_BLL_Rutina.Guardar(o_BE_Rutina);
            CargardataGridView1();
        }

        private void btn_Eliminar_Rut_Click(object sender, EventArgs e)
        {
            o_BE_Rutina = (BE_Rutina)this.dataGridView1.CurrentRow.DataBoundItem;
            if (o_BLL_Rutina.Borrar(o_BE_Rutina) == false)
                MessageBox.Show("La rutina " + o_BE_Rutina.Descripcion + " tiene Ejercicios asociados");
            CargardataGridView1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            o_BE_Rutina = (BE_Rutina)this.dataGridView1.CurrentRow.DataBoundItem;
            textBox1_Codigo_Rut.Text = o_BE_Rutina.Codigo.ToString();
            texbox_Descripcion_Rut.Text = o_BE_Rutina.Descripcion;
            o_BLL_Rutina.TraerEjercicios(o_BE_Rutina);
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = o_BE_Rutina.RetornaEjercicios();
        }
    }
}
