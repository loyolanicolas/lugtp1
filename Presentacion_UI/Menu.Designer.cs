
namespace Presentacion_UI
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.entrenadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // entrenadoresToolStripMenuItem
            // 
            this.entrenadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrenadoresToolStripMenuItem1,
            this.deportistasToolStripMenuItem,
            this.rutinaToolStripMenuItem});
            this.entrenadoresToolStripMenuItem.Name = "entrenadoresToolStripMenuItem";
            this.entrenadoresToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.entrenadoresToolStripMenuItem.Text = "Formularios";
            // 
            // entrenadoresToolStripMenuItem1
            // 
            this.entrenadoresToolStripMenuItem1.Name = "entrenadoresToolStripMenuItem1";
            this.entrenadoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.entrenadoresToolStripMenuItem1.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem1.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem1_Click);
            // 
            // deportistasToolStripMenuItem
            // 
            this.deportistasToolStripMenuItem.Name = "deportistasToolStripMenuItem";
            this.deportistasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deportistasToolStripMenuItem.Text = "Deportistas";
            this.deportistasToolStripMenuItem.Click += new System.EventHandler(this.deportistasToolStripMenuItem_Click);
            // 
            // rutinaToolStripMenuItem
            // 
            this.rutinaToolStripMenuItem.Name = "rutinaToolStripMenuItem";
            this.rutinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rutinaToolStripMenuItem.Text = "Rutinas";
            this.rutinaToolStripMenuItem.Click += new System.EventHandler(this.rutinaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 539);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutinaToolStripMenuItem;
    }
}

