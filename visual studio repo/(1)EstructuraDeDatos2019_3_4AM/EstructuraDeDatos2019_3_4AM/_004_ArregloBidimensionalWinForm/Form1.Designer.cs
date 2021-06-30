namespace _004_ArregloBidimensionalWinForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMesMayorDulces = new System.Windows.Forms.Button();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.buttonMesMenorBebidas = new System.Windows.Forms.Button();
            this.buttonDeptMenorVentas = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "-VENTAS MENSUALES-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 378);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // buttonMesMayorDulces
            // 
            this.buttonMesMayorDulces.Location = new System.Drawing.Point(529, 62);
            this.buttonMesMayorDulces.Name = "buttonMesMayorDulces";
            this.buttonMesMayorDulces.Size = new System.Drawing.Size(132, 42);
            this.buttonMesMayorDulces.TabIndex = 2;
            this.buttonMesMayorDulces.Text = "&Mes mayor";
            this.buttonMesMayorDulces.UseVisualStyleBackColor = true;
            this.buttonMesMayorDulces.Click += new System.EventHandler(this.buttonMesMayorDulces_Click);
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Location = new System.Drawing.Point(529, 127);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(132, 62);
            this.buttonPromedio.TabIndex = 3;
            this.buttonPromedio.Text = "&Promedioanual de ventas de bebidas";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            // 
            // buttonMesMenorBebidas
            // 
            this.buttonMesMenorBebidas.Location = new System.Drawing.Point(529, 204);
            this.buttonMesMenorBebidas.Name = "buttonMesMenorBebidas";
            this.buttonMesMenorBebidas.Size = new System.Drawing.Size(132, 49);
            this.buttonMesMenorBebidas.TabIndex = 4;
            this.buttonMesMenorBebidas.Text = "&Mes menor en ventas de bebidas";
            this.buttonMesMenorBebidas.UseVisualStyleBackColor = true;
            // 
            // buttonDeptMenorVentas
            // 
            this.buttonDeptMenorVentas.Location = new System.Drawing.Point(529, 269);
            this.buttonDeptMenorVentas.Name = "buttonDeptMenorVentas";
            this.buttonDeptMenorVentas.Size = new System.Drawing.Size(132, 60);
            this.buttonDeptMenorVentas.TabIndex = 5;
            this.buttonDeptMenorVentas.Text = "&Departamento con menor ventas en agosto";
            this.buttonDeptMenorVentas.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(529, 348);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(132, 39);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "&Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonDeptMenorVentas);
            this.Controls.Add(this.buttonMesMenorBebidas);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.buttonMesMayorDulces);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMesMayorDulces;
        private System.Windows.Forms.Button buttonPromedio;
        private System.Windows.Forms.Button buttonMesMenorBebidas;
        private System.Windows.Forms.Button buttonDeptMenorVentas;
        private System.Windows.Forms.Button buttonSalir;
    }
}

