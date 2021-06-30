namespace _002b_Libreria
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_X1 = new System.Windows.Forms.TextBox();
            this.TB_Y1 = new System.Windows.Forms.TextBox();
            this.BT_Linea = new System.Windows.Forms.Button();
            this.TB_Y2 = new System.Windows.Forms.TextBox();
            this.TB_X2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelDeDibujo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // TB_X1
            // 
            this.TB_X1.Location = new System.Drawing.Point(125, 42);
            this.TB_X1.Name = "TB_X1";
            this.TB_X1.Size = new System.Drawing.Size(100, 22);
            this.TB_X1.TabIndex = 2;
            // 
            // TB_Y1
            // 
            this.TB_Y1.Location = new System.Drawing.Point(125, 79);
            this.TB_Y1.Name = "TB_Y1";
            this.TB_Y1.Size = new System.Drawing.Size(100, 22);
            this.TB_Y1.TabIndex = 3;
            // 
            // BT_Linea
            // 
            this.BT_Linea.Location = new System.Drawing.Point(244, 53);
            this.BT_Linea.Name = "BT_Linea";
            this.BT_Linea.Size = new System.Drawing.Size(98, 33);
            this.BT_Linea.TabIndex = 4;
            this.BT_Linea.Text = "Dibujar linea";
            this.BT_Linea.UseVisualStyleBackColor = true;
            this.BT_Linea.Click += new System.EventHandler(this.BT_Linea_Click);
            // 
            // TB_Y2
            // 
            this.TB_Y2.Location = new System.Drawing.Point(125, 165);
            this.TB_Y2.Name = "TB_Y2";
            this.TB_Y2.Size = new System.Drawing.Size(100, 22);
            this.TB_Y2.TabIndex = 8;
            // 
            // TB_X2
            // 
            this.TB_X2.Location = new System.Drawing.Point(125, 128);
            this.TB_X2.Name = "TB_X2";
            this.TB_X2.Size = new System.Drawing.Size(100, 22);
            this.TB_X2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            // 
            // PanelDeDibujo
            // 
            this.PanelDeDibujo.Location = new System.Drawing.Point(395, 53);
            this.PanelDeDibujo.Name = "PanelDeDibujo";
            this.PanelDeDibujo.Size = new System.Drawing.Size(364, 305);
            this.PanelDeDibujo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDeDibujo);
            this.Controls.Add(this.TB_Y2);
            this.Controls.Add(this.TB_X2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_Linea);
            this.Controls.Add(this.TB_Y1);
            this.Controls.Add(this.TB_X1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_X1;
        private System.Windows.Forms.TextBox TB_Y1;
        private System.Windows.Forms.Button BT_Linea;
        private System.Windows.Forms.TextBox TB_Y2;
        private System.Windows.Forms.TextBox TB_X2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelDeDibujo;
    }
}

