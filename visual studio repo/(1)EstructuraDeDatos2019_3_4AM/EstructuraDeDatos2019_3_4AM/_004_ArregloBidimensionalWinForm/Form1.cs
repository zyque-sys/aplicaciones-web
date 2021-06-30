using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_ArregloBidimensionalWinForm
{
    public partial class Form1 : Form
    {
        RegistroDeMes [] registro;
        ClaseMatriz matriz;
        public Form1()
        {
            InitializeComponent();
            matriz = new ClaseMatriz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registro = new RegistroDeMes[12] 
            {
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30),
                new RegistroDeMes(12,6,30)
            };//fin de instancia del arreglo
            dataGridView1.DataSource = registro;
        }//fin de Form1_Load

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].HeaderCell.Value = ObtenerMes(e.RowIndex);
        }

        private string ObtenerMes(int mes)
        {
            switch (mes)
            {
                case 0:return "Enero";
                case 1: return "Febrero";
                case 2: return "Marzo";
                case 3: return "Abril";
                case 4: return "Mayo";
                case 5: return "Junio";
                case 6: return "Julio";
                case 7: return "Agosto";
                case 8: return "Septiembre";
                case 9: return "Octubre";
                case 10: return "Noviembre";
                case 11: return "Diciembre";
            }
            return "";

        }

        private void buttonMesMayorDulces_Click(object sender, EventArgs e)
        {
            string mes = "";
            double ventaMayor = 0;
            LlenarMatriz();
            matriz.ObtenerMesVentaMayorDulces(ref mes,ref ventaMayor);
            MessageBox.Show("El mes con mayor venta de dulces es\n "+mes+" con $"+ventaMayor);
        }

        private void LlenarMatriz()
        {
            for (int r = 0; r < 12; r++)
            {
                matriz[r, 0] = Convert.ToDouble(dataGridView1.Rows[r].Cells["Dulces"].Value);
                matriz[r, 1] = Convert.ToDouble(dataGridView1.Rows[r].Cells["Conservas"].Value);
                matriz[r, 2] = Convert.ToDouble(dataGridView1.Rows[r].Cells["Bebidas"].Value);
            }

        }
    }
}
