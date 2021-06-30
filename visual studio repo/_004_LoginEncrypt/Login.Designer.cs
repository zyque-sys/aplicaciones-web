
namespace _004_LoginEncrypt
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
            this.LB_iniciarsesion = new System.Windows.Forms.Label();
            this.LB_usuario = new System.Windows.Forms.Label();
            this.TB_contrasenha = new System.Windows.Forms.Label();
            this.TB_loginusuario = new System.Windows.Forms.TextBox();
            this.TB_logincontrasenha = new System.Windows.Forms.TextBox();
            this.BT_loginingreesar = new System.Windows.Forms.Button();
            this.BT_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_iniciarsesion
            // 
            this.LB_iniciarsesion.AutoSize = true;
            this.LB_iniciarsesion.Location = new System.Drawing.Point(350, 37);
            this.LB_iniciarsesion.Name = "LB_iniciarsesion";
            this.LB_iniciarsesion.Size = new System.Drawing.Size(96, 20);
            this.LB_iniciarsesion.TabIndex = 0;
            this.LB_iniciarsesion.Text = "Iniciar Sesión";
            // 
            // LB_usuario
            // 
            this.LB_usuario.AutoSize = true;
            this.LB_usuario.Location = new System.Drawing.Point(271, 83);
            this.LB_usuario.Name = "LB_usuario";
            this.LB_usuario.Size = new System.Drawing.Size(62, 20);
            this.LB_usuario.TabIndex = 1;
            this.LB_usuario.Text = "Usuario:";
            // 
            // TB_contrasenha
            // 
            this.TB_contrasenha.AutoSize = true;
            this.TB_contrasenha.Location = new System.Drawing.Point(247, 127);
            this.TB_contrasenha.Name = "TB_contrasenha";
            this.TB_contrasenha.Size = new System.Drawing.Size(86, 20);
            this.TB_contrasenha.TabIndex = 2;
            this.TB_contrasenha.Text = "Contraseña:";
            // 
            // TB_loginusuario
            // 
            this.TB_loginusuario.Location = new System.Drawing.Point(339, 83);
            this.TB_loginusuario.Name = "TB_loginusuario";
            this.TB_loginusuario.Size = new System.Drawing.Size(125, 27);
            this.TB_loginusuario.TabIndex = 3;
            // 
            // TB_logincontrasenha
            // 
            this.TB_logincontrasenha.Location = new System.Drawing.Point(339, 124);
            this.TB_logincontrasenha.Name = "TB_logincontrasenha";
            this.TB_logincontrasenha.Size = new System.Drawing.Size(125, 27);
            this.TB_logincontrasenha.TabIndex = 4;
            // 
            // BT_loginingreesar
            // 
            this.BT_loginingreesar.Location = new System.Drawing.Point(409, 185);
            this.BT_loginingreesar.Name = "BT_loginingreesar";
            this.BT_loginingreesar.Size = new System.Drawing.Size(94, 29);
            this.BT_loginingreesar.TabIndex = 5;
            this.BT_loginingreesar.Text = "Ingresar";
            this.BT_loginingreesar.UseVisualStyleBackColor = true;
            this.BT_loginingreesar.Click += new System.EventHandler(this.BT_loginingreesar_Click);
            // 
            // BT_Register
            // 
            this.BT_Register.Location = new System.Drawing.Point(295, 185);
            this.BT_Register.Name = "BT_Register";
            this.BT_Register.Size = new System.Drawing.Size(94, 29);
            this.BT_Register.TabIndex = 6;
            this.BT_Register.Text = "Registrarse";
            this.BT_Register.UseVisualStyleBackColor = true;
            this.BT_Register.Click += new System.EventHandler(this.BT_Register_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Register);
            this.Controls.Add(this.BT_loginingreesar);
            this.Controls.Add(this.TB_logincontrasenha);
            this.Controls.Add(this.TB_loginusuario);
            this.Controls.Add(this.TB_contrasenha);
            this.Controls.Add(this.LB_usuario);
            this.Controls.Add(this.LB_iniciarsesion);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_iniciarsesion;
        private System.Windows.Forms.Label LB_usuario;
        private System.Windows.Forms.Label TB_contrasenha;
        private System.Windows.Forms.TextBox TB_loginusuario;
        private System.Windows.Forms.TextBox TB_logincontrasenha;
        private System.Windows.Forms.Button BT_loginingreesar;
        private System.Windows.Forms.Button BT_Register;
    }
}