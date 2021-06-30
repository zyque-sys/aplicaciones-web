namespace _002b_Libreria.PanelDeDibujo
{
    partial class Dibujo
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
            this.GB_Formas = new System.Windows.Forms.GroupBox();
            this.RB_Elipse = new System.Windows.Forms.RadioButton();
            this.RB_Rectangulo = new System.Windows.Forms.RadioButton();
            this.RB_Linea = new System.Windows.Forms.RadioButton();
            this.GB_Pluma = new System.Windows.Forms.GroupBox();
            this.CB_Grosor = new System.Windows.Forms.ComboBox();
            this.CB_Color = new System.Windows.Forms.ComboBox();
            this.LB_MouseDownLocation = new System.Windows.Forms.Label();
            this.LB_MouseUpLocation = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.LB_Coordenada = new System.Windows.Forms.Label();
            this.LB_Forma = new System.Windows.Forms.Label();
            this.GB_Formas.SuspendLayout();
            this.GB_Pluma.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Formas
            // 
            this.GB_Formas.Controls.Add(this.RB_Elipse);
            this.GB_Formas.Controls.Add(this.RB_Rectangulo);
            this.GB_Formas.Controls.Add(this.RB_Linea);
            this.GB_Formas.Location = new System.Drawing.Point(13, 13);
            this.GB_Formas.Name = "GB_Formas";
            this.GB_Formas.Size = new System.Drawing.Size(200, 100);
            this.GB_Formas.TabIndex = 0;
            this.GB_Formas.TabStop = false;
            this.GB_Formas.Text = "Formas";
            // 
            // RB_Elipse
            // 
            this.RB_Elipse.AutoSize = true;
            this.RB_Elipse.Location = new System.Drawing.Point(7, 73);
            this.RB_Elipse.Name = "RB_Elipse";
            this.RB_Elipse.Size = new System.Drawing.Size(67, 21);
            this.RB_Elipse.TabIndex = 2;
            this.RB_Elipse.TabStop = true;
            this.RB_Elipse.Text = "Elipse";
            this.RB_Elipse.UseVisualStyleBackColor = true;
            // 
            // RB_Rectangulo
            // 
            this.RB_Rectangulo.AutoSize = true;
            this.RB_Rectangulo.Location = new System.Drawing.Point(6, 46);
            this.RB_Rectangulo.Name = "RB_Rectangulo";
            this.RB_Rectangulo.Size = new System.Drawing.Size(101, 21);
            this.RB_Rectangulo.TabIndex = 1;
            this.RB_Rectangulo.TabStop = true;
            this.RB_Rectangulo.Text = "Rectángulo";
            this.RB_Rectangulo.UseVisualStyleBackColor = true;
            // 
            // RB_Linea
            // 
            this.RB_Linea.AutoSize = true;
            this.RB_Linea.Location = new System.Drawing.Point(7, 21);
            this.RB_Linea.Name = "RB_Linea";
            this.RB_Linea.Size = new System.Drawing.Size(64, 21);
            this.RB_Linea.TabIndex = 0;
            this.RB_Linea.TabStop = true;
            this.RB_Linea.Text = "Linea";
            this.RB_Linea.UseVisualStyleBackColor = true;
            // 
            // GB_Pluma
            // 
            this.GB_Pluma.Controls.Add(this.CB_Grosor);
            this.GB_Pluma.Controls.Add(this.CB_Color);
            this.GB_Pluma.Location = new System.Drawing.Point(13, 131);
            this.GB_Pluma.Name = "GB_Pluma";
            this.GB_Pluma.Size = new System.Drawing.Size(200, 100);
            this.GB_Pluma.TabIndex = 1;
            this.GB_Pluma.TabStop = false;
            this.GB_Pluma.Text = "Pluma";
            // 
            // CB_Grosor
            // 
            this.CB_Grosor.FormattingEnabled = true;
            this.CB_Grosor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CB_Grosor.Location = new System.Drawing.Point(7, 65);
            this.CB_Grosor.Name = "CB_Grosor";
            this.CB_Grosor.Size = new System.Drawing.Size(167, 24);
            this.CB_Grosor.TabIndex = 0;
            // 
            // CB_Color
            // 
            this.CB_Color.FormattingEnabled = true;
            this.CB_Color.Items.AddRange(new object[] {
            "Negro",
            "Azul",
            "Amarillo",
            "Rojo",
            "Verde"});
            this.CB_Color.Location = new System.Drawing.Point(7, 35);
            this.CB_Color.Name = "CB_Color";
            this.CB_Color.Size = new System.Drawing.Size(167, 24);
            this.CB_Color.TabIndex = 0;
            // 
            // LB_MouseDownLocation
            // 
            this.LB_MouseDownLocation.AutoSize = true;
            this.LB_MouseDownLocation.Location = new System.Drawing.Point(706, 95);
            this.LB_MouseDownLocation.Name = "LB_MouseDownLocation";
            this.LB_MouseDownLocation.Size = new System.Drawing.Size(48, 17);
            this.LB_MouseDownLocation.TabIndex = 2;
            this.LB_MouseDownLocation.Text = "{X , Y}";
            // 
            // LB_MouseUpLocation
            // 
            this.LB_MouseUpLocation.AutoSize = true;
            this.LB_MouseUpLocation.Location = new System.Drawing.Point(706, 131);
            this.LB_MouseUpLocation.Name = "LB_MouseUpLocation";
            this.LB_MouseUpLocation.Size = new System.Drawing.Size(48, 17);
            this.LB_MouseUpLocation.TabIndex = 3;
            this.LB_MouseUpLocation.Text = "{X , Y}";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(243, 25);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(420, 398);
            this.Panel.TabIndex = 4;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.Panel.MouseLeave += new System.EventHandler(this.Panel_MouseHover);
            this.Panel.MouseHover += new System.EventHandler(this.Panel_MouseHover);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // LB_Coordenada
            // 
            this.LB_Coordenada.AutoSize = true;
            this.LB_Coordenada.Location = new System.Drawing.Point(670, 405);
            this.LB_Coordenada.Name = "LB_Coordenada";
            this.LB_Coordenada.Size = new System.Drawing.Size(0, 17);
            this.LB_Coordenada.TabIndex = 6;
            // 
            // LB_Forma
            // 
            this.LB_Forma.AutoSize = true;
            this.LB_Forma.Location = new System.Drawing.Point(243, 430);
            this.LB_Forma.Name = "LB_Forma";
            this.LB_Forma.Size = new System.Drawing.Size(0, 17);
            this.LB_Forma.TabIndex = 7;
            // 
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Forma);
            this.Controls.Add(this.LB_Coordenada);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.LB_MouseUpLocation);
            this.Controls.Add(this.LB_MouseDownLocation);
            this.Controls.Add(this.GB_Pluma);
            this.Controls.Add(this.GB_Formas);
            this.Name = "Dibujo";
            this.Text = "Dibujo";
            this.GB_Formas.ResumeLayout(false);
            this.GB_Formas.PerformLayout();
            this.GB_Pluma.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Formas;
        private System.Windows.Forms.GroupBox GB_Pluma;
        private System.Windows.Forms.Label LB_MouseDownLocation;
        private System.Windows.Forms.Label LB_MouseUpLocation;
        private System.Windows.Forms.ComboBox CB_Color;
        private System.Windows.Forms.ComboBox CB_Grosor;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.RadioButton RB_Elipse;
        private System.Windows.Forms.RadioButton RB_Rectangulo;
        private System.Windows.Forms.RadioButton RB_Linea;
        private System.Windows.Forms.Label LB_Coordenada;
        private System.Windows.Forms.Label LB_Forma;
    }
}