
namespace _004_LoginEncrypt
{
    partial class MainScrn
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
            this.LB_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_welcome
            // 
            this.LB_welcome.AutoSize = true;
            this.LB_welcome.Location = new System.Drawing.Point(279, 94);
            this.LB_welcome.Name = "LB_welcome";
            this.LB_welcome.Size = new System.Drawing.Size(83, 20);
            this.LB_welcome.TabIndex = 0;
            this.LB_welcome.Text = "Bienvenido";
            // 
            // MainScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_welcome);
            this.Name = "MainScrn";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_welcome;
    }
}