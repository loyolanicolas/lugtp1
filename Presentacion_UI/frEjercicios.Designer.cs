
namespace Presentacion_UI
{
    partial class frEjercicios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.texbox_Detalle_Ejer = new System.Windows.Forms.TextBox();
            this.btn_Alta_Ejer = new System.Windows.Forms.Button();
            this.btn_Mod_Ejer = new System.Windows.Forms.Button();
            this.btn_Baja_Ejer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(250, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle";
            // 
            // texbox_Detalle_Ejer
            // 
            this.texbox_Detalle_Ejer.Location = new System.Drawing.Point(12, 105);
            this.texbox_Detalle_Ejer.Name = "texbox_Detalle_Ejer";
            this.texbox_Detalle_Ejer.Size = new System.Drawing.Size(246, 20);
            this.texbox_Detalle_Ejer.TabIndex = 14;
            // 
            // btn_Alta_Ejer
            // 
            this.btn_Alta_Ejer.Location = new System.Drawing.Point(60, 147);
            this.btn_Alta_Ejer.Name = "btn_Alta_Ejer";
            this.btn_Alta_Ejer.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta_Ejer.TabIndex = 15;
            this.btn_Alta_Ejer.Text = "AGREGAR";
            this.btn_Alta_Ejer.UseVisualStyleBackColor = true;
            // 
            // btn_Mod_Ejer
            // 
            this.btn_Mod_Ejer.Location = new System.Drawing.Point(60, 217);
            this.btn_Mod_Ejer.Name = "btn_Mod_Ejer";
            this.btn_Mod_Ejer.Size = new System.Drawing.Size(75, 23);
            this.btn_Mod_Ejer.TabIndex = 16;
            this.btn_Mod_Ejer.Text = "MODIFICAR";
            this.btn_Mod_Ejer.UseVisualStyleBackColor = true;
            this.btn_Mod_Ejer.Click += new System.EventHandler(this.btn_Mod_Ejer_Click);
            // 
            // btn_Baja_Ejer
            // 
            this.btn_Baja_Ejer.Location = new System.Drawing.Point(60, 291);
            this.btn_Baja_Ejer.Name = "btn_Baja_Ejer";
            this.btn_Baja_Ejer.Size = new System.Drawing.Size(75, 23);
            this.btn_Baja_Ejer.TabIndex = 17;
            this.btn_Baja_Ejer.Text = "ELIMINAR";
            this.btn_Baja_Ejer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "NRO";
            // 
            // frEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 398);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Baja_Ejer);
            this.Controls.Add(this.btn_Mod_Ejer);
            this.Controls.Add(this.btn_Alta_Ejer);
            this.Controls.Add(this.texbox_Detalle_Ejer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frEjercicios";
            this.Text = "Ejercicios";
            this.Load += new System.EventHandler(this.frEjercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texbox_Detalle_Ejer;
        private System.Windows.Forms.Button btn_Alta_Ejer;
        private System.Windows.Forms.Button btn_Mod_Ejer;
        private System.Windows.Forms.Button btn_Baja_Ejer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}