
namespace _004_LoginEncrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_usuario = new System.Windows.Forms.Label();
            this.LB_contrasenha = new System.Windows.Forms.Label();
            this.BT_login = new System.Windows.Forms.Button();
            this.LB_registrarse = new System.Windows.Forms.Label();
            this.TB_usuario = new System.Windows.Forms.TextBox();
            this.TB_contrasenha = new System.Windows.Forms.TextBox();
            this.TB_confirmarpw = new System.Windows.Forms.TextBox();
            this.LB_confirmarpw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_usuario
            // 
            this.LB_usuario.AutoSize = true;
            this.LB_usuario.Location = new System.Drawing.Point(211, 114);
            this.LB_usuario.Name = "LB_usuario";
            this.LB_usuario.Size = new System.Drawing.Size(59, 20);
            this.LB_usuario.TabIndex = 0;
            this.LB_usuario.Text = "Usuario";
            // 
            // LB_contrasenha
            // 
            this.LB_contrasenha.AutoSize = true;
            this.LB_contrasenha.Location = new System.Drawing.Point(187, 153);
            this.LB_contrasenha.Name = "LB_contrasenha";
            this.LB_contrasenha.Size = new System.Drawing.Size(83, 20);
            this.LB_contrasenha.TabIndex = 1;
            this.LB_contrasenha.Text = "Contraseña";
            // 
            // BT_login
            // 
            this.BT_login.Location = new System.Drawing.Point(308, 277);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(94, 29);
            this.BT_login.TabIndex = 2;
            this.BT_login.Text = "Ingresar";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // LB_registrarse
            // 
            this.LB_registrarse.AutoSize = true;
            this.LB_registrarse.Location = new System.Drawing.Point(308, 45);
            this.LB_registrarse.Name = "LB_registrarse";
            this.LB_registrarse.Size = new System.Drawing.Size(82, 20);
            this.LB_registrarse.TabIndex = 3;
            this.LB_registrarse.Text = "Registrarse";
            // 
            // TB_usuario
            // 
            this.TB_usuario.Location = new System.Drawing.Point(288, 111);
            this.TB_usuario.Name = "TB_usuario";
            this.TB_usuario.Size = new System.Drawing.Size(133, 27);
            this.TB_usuario.TabIndex = 4;
            // 
            // TB_contrasenha
            // 
            this.TB_contrasenha.Location = new System.Drawing.Point(288, 150);
            this.TB_contrasenha.Name = "TB_contrasenha";
            this.TB_contrasenha.PasswordChar = '*';
            this.TB_contrasenha.Size = new System.Drawing.Size(133, 27);
            this.TB_contrasenha.TabIndex = 5;
            // 
            // TB_confirmarpw
            // 
            this.TB_confirmarpw.Location = new System.Drawing.Point(288, 194);
            this.TB_confirmarpw.Name = "TB_confirmarpw";
            this.TB_confirmarpw.PasswordChar = '*';
            this.TB_confirmarpw.Size = new System.Drawing.Size(133, 27);
            this.TB_confirmarpw.TabIndex = 6;
            // 
            // LB_confirmarpw
            // 
            this.LB_confirmarpw.AutoSize = true;
            this.LB_confirmarpw.Location = new System.Drawing.Point(119, 197);
            this.LB_confirmarpw.Name = "LB_confirmarpw";
            this.LB_confirmarpw.Size = new System.Drawing.Size(151, 20);
            this.LB_confirmarpw.TabIndex = 7;
            this.LB_confirmarpw.Text = "Confirmar contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_confirmarpw);
            this.Controls.Add(this.TB_confirmarpw);
            this.Controls.Add(this.TB_contrasenha);
            this.Controls.Add(this.TB_usuario);
            this.Controls.Add(this.LB_registrarse);
            this.Controls.Add(this.BT_login);
            this.Controls.Add(this.LB_contrasenha);
            this.Controls.Add(this.LB_usuario);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_usuario;
        private System.Windows.Forms.Label LB_contrasenha;
        private System.Windows.Forms.Button BT_login;
        private System.Windows.Forms.Label LB_registrarse;
        private System.Windows.Forms.TextBox TB_usuario;
        private System.Windows.Forms.TextBox TB_contrasenha;
        private System.Windows.Forms.TextBox TB_confirmarpw;
        private System.Windows.Forms.Label LB_confirmarpw;
    }
}

