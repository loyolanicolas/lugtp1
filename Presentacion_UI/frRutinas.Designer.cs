
namespace Presentacion_UI
{
    partial class frRutinas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Agregar_Rut = new System.Windows.Forms.Button();
            this.btn_MOD_Rut = new System.Windows.Forms.Button();
            this.btn_Eliminar_Rut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.texbox_Nombre_Deportista = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar_Rut
            // 
            this.btn_Agregar_Rut.Location = new System.Drawing.Point(12, 133);
            this.btn_Agregar_Rut.Name = "btn_Agregar_Rut";
            this.btn_Agregar_Rut.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar_Rut.TabIndex = 0;
            this.btn_Agregar_Rut.Text = "Agregar";
            this.btn_Agregar_Rut.UseVisualStyleBackColor = true;
            // 
            // btn_MOD_Rut
            // 
            this.btn_MOD_Rut.Location = new System.Drawing.Point(100, 133);
            this.btn_MOD_Rut.Name = "btn_MOD_Rut";
            this.btn_MOD_Rut.Size = new System.Drawing.Size(75, 23);
            this.btn_MOD_Rut.TabIndex = 1;
            this.btn_MOD_Rut.Text = "Modificar";
            this.btn_MOD_Rut.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar_Rut
            // 
            this.btn_Eliminar_Rut.Location = new System.Drawing.Point(194, 133);
            this.btn_Eliminar_Rut.Name = "btn_Eliminar_Rut";
            this.btn_Eliminar_Rut.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar_Rut.TabIndex = 2;
            this.btn_Eliminar_Rut.Text = "Eliminar";
            this.btn_Eliminar_Rut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion";
            // 
            // texbox_Nombre_Deportista
            // 
            this.texbox_Nombre_Deportista.Location = new System.Drawing.Point(12, 71);
            this.texbox_Nombre_Deportista.Name = "texbox_Nombre_Deportista";
            this.texbox_Nombre_Deportista.Size = new System.Drawing.Size(246, 20);
            this.texbox_Nombre_Deportista.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 205);
            this.dataGridView1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar ejercicio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.texbox_Nombre_Deportista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar_Rut);
            this.Controls.Add(this.btn_MOD_Rut);
            this.Controls.Add(this.btn_Agregar_Rut);
            this.Name = "frRutinas";
            this.Text = "frRutinas";
            this.Load += new System.EventHandler(this.frRutinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar_Rut;
        private System.Windows.Forms.Button btn_MOD_Rut;
        private System.Windows.Forms.Button btn_Eliminar_Rut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texbox_Nombre_Deportista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}