namespace _002b_ProyectoSystemDrawing
{
    partial class Oso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GB_Lineas = new System.Windows.Forms.GroupBox();
            this.CB_TorsoLinea = new System.Windows.Forms.CheckBox();
            this.CB_Cara = new System.Windows.Forms.CheckBox();
            this.LB_Coordenadas = new System.Windows.Forms.Label();
            this.CB_BrazoIzq = new System.Windows.Forms.CheckBox();
            this.CB_Piernas = new System.Windows.Forms.CheckBox();
            this.GB_Lineas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 624);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GB_Lineas
            // 
            this.GB_Lineas.Controls.Add(this.CB_Piernas);
            this.GB_Lineas.Controls.Add(this.CB_BrazoIzq);
            this.GB_Lineas.Controls.Add(this.CB_TorsoLinea);
            this.GB_Lineas.Controls.Add(this.CB_Cara);
            this.GB_Lineas.Location = new System.Drawing.Point(546, 12);
            this.GB_Lineas.Name = "GB_Lineas";
            this.GB_Lineas.Size = new System.Drawing.Size(366, 163);
            this.GB_Lineas.TabIndex = 4;
            this.GB_Lineas.TabStop = false;
            this.GB_Lineas.Text = "Lineas";
            // 
            // CB_TorsoLinea
            // 
            this.CB_TorsoLinea.AutoSize = true;
            this.CB_TorsoLinea.Location = new System.Drawing.Point(6, 49);
            this.CB_TorsoLinea.Name = "CB_TorsoLinea";
            this.CB_TorsoLinea.Size = new System.Drawing.Size(67, 21);
            this.CB_TorsoLinea.TabIndex = 1;
            this.CB_TorsoLinea.Text = "Torso";
            this.CB_TorsoLinea.UseVisualStyleBackColor = true;
            this.CB_TorsoLinea.CheckedChanged += new System.EventHandler(this.CB_TorsoLinea_CheckedChanged);
            // 
            // CB_Cara
            // 
            this.CB_Cara.AutoSize = true;
            this.CB_Cara.Location = new System.Drawing.Point(7, 22);
            this.CB_Cara.Name = "CB_Cara";
            this.CB_Cara.Size = new System.Drawing.Size(60, 21);
            this.CB_Cara.TabIndex = 0;
            this.CB_Cara.Text = "Cara";
            this.CB_Cara.UseVisualStyleBackColor = true;
            this.CB_Cara.CheckedChanged += new System.EventHandler(this.CB_Cara_CheckedChanged);
            // 
            // LB_Coordenadas
            // 
            this.LB_Coordenadas.AutoSize = true;
            this.LB_Coordenadas.Location = new System.Drawing.Point(678, 456);
            this.LB_Coordenadas.Name = "LB_Coordenadas";
            this.LB_Coordenadas.Size = new System.Drawing.Size(40, 17);
            this.LB_Coordenadas.TabIndex = 3;
            this.LB_Coordenadas.Text = "{X,Y}";
            // 
            // CB_BrazoIzq
            // 
            this.CB_BrazoIzq.AutoSize = true;
            this.CB_BrazoIzq.Location = new System.Drawing.Point(6, 76);
            this.CB_BrazoIzq.Name = "CB_BrazoIzq";
            this.CB_BrazoIzq.Size = new System.Drawing.Size(74, 21);
            this.CB_BrazoIzq.TabIndex = 2;
            this.CB_BrazoIzq.Text = "Brazos";
            this.CB_BrazoIzq.UseVisualStyleBackColor = true;
            this.CB_BrazoIzq.CheckedChanged += new System.EventHandler(this.CB_BrazoIzq_CheckedChanged);
            // 
            // CB_Piernas
            // 
            this.CB_Piernas.AutoSize = true;
            this.CB_Piernas.Location = new System.Drawing.Point(6, 104);
            this.CB_Piernas.Name = "CB_Piernas";
            this.CB_Piernas.Size = new System.Drawing.Size(78, 21);
            this.CB_Piernas.TabIndex = 3;
            this.CB_Piernas.Text = "Piernas";
            this.CB_Piernas.UseVisualStyleBackColor = true;
            this.CB_Piernas.CheckedChanged += new System.EventHandler(this.CB_Piernas_CheckedChanged);
            // 
            // Oso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 648);
            this.Controls.Add(this.LB_Coordenadas);
            this.Controls.Add(this.GB_Lineas);
            this.Controls.Add(this.panel1);
            this.Name = "Oso";
            this.Text = "Oso";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Oso_Paint);
            this.GB_Lineas.ResumeLayout(false);
            this.GB_Lineas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GB_Lineas;
        private System.Windows.Forms.CheckBox CB_TorsoLinea;
        private System.Windows.Forms.CheckBox CB_Cara;
        private System.Windows.Forms.Label LB_Coordenadas;
        private System.Windows.Forms.CheckBox CB_BrazoIzq;
        private System.Windows.Forms.CheckBox CB_Piernas;
    }
}

