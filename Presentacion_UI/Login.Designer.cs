
namespace Presentacion_UI
{
    partial class Login
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
            this.textbox_Usuario_Login = new System.Windows.Forms.TextBox();
            this.textbox_Contraseña_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ingresar_Login = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textbox_Usuario_Login
            // 
            this.textbox_Usuario_Login.Location = new System.Drawing.Point(103, 19);
            this.textbox_Usuario_Login.Name = "textbox_Usuario_Login";
            this.textbox_Usuario_Login.Size = new System.Drawing.Size(159, 20);
            this.textbox_Usuario_Login.TabIndex = 0;
            // 
            // textbox_Contraseña_Login
            // 
            this.textbox_Contraseña_Login.Location = new System.Drawing.Point(103, 52);
            this.textbox_Contraseña_Login.Name = "textbox_Contraseña_Login";
            this.textbox_Contraseña_Login.Size = new System.Drawing.Size(159, 20);
            this.textbox_Contraseña_Login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // btn_Ingresar_Login
            // 
            this.btn_Ingresar_Login.Location = new System.Drawing.Point(187, 91);
            this.btn_Ingresar_Login.Name = "btn_Ingresar_Login";
            this.btn_Ingresar_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar_Login.TabIndex = 4;
            this.btn_Ingresar_Login.Text = "Ingresar";
            this.btn_Ingresar_Login.UseVisualStyleBackColor = true;
            this.btn_Ingresar_Login.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Location = new System.Drawing.Point(4, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 13);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TabStop = true;
            this.btnSalir.Text = "Salir";
            this.btnSalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSalir_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(317, 150);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_Ingresar_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_Contraseña_Login);
            this.Controls.Add(this.textbox_Usuario_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Usuario_Login;
        private System.Windows.Forms.TextBox textbox_Contraseña_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ingresar_Login;
        private System.Windows.Forms.LinkLabel btnSalir;
    }
}