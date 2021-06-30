using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_ComponentesGraficos.Practicas.Controles
{


    //    private void button2_Click(object sender, EventArgs e)
    //    {
    //        if (!EquipoDeBaseball.EstaVacio())
    //        {
    //            string NumUniforme = textBox1.Text;

    //            if (NumUniforme == "") 
    //            {
    //                DataGridViewRow RenglonSeleccionado = dataGridView1.CurrentRow;
    //                if (RenglonSeleccionado == null) 
    //                    MessageBox.Show("Escriba el número de uniforme del jugador a eliminar o selecciónalo de la cuadricula", "[!]ERROR[!]:", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                else
    //                    NumUniforme = RenglonSeleccionado.Cells[0].Value.ToString();
                    
    //            }

                
    //            if (MessageBox.Show("¿ Está seguro que desea eliminar el jugador num." + NumUniforme + " ? ", "Presione un botón para continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    //            {
    //                if (EquipoDeBaseball.Eliminar(UInt16.Parse(NumUniforme)))
    //                    MessageBox.Show("Se eliminó el jugador");
    //                else
    //                    MessageBox.Show("No se pudo eliminar el jugador num." + NumUniforme, "[!]ERROR[!]:", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            }
    //            else
    //                MessageBox.Show("Eliminación cancelada", "[!]ERROR[!]:", MessageBoxButtons.OK, MessageBoxIcon.Error);

    //            MostrarDataGrid();
    //        }
    //        else
    //            MessageBox.Show("Arreglo vacío :(");
    //    }

    //    private void button3_Click(object sender, EventArgs e)
    //    {
    //        if (EquipoDeBaseball.Ordenar())  // Invoca el método Ordenar()
    //        {
    //            MostrarDataGrid();
    //        }
    //        else
    //            MessageBox.Show("Arreglo vacío :(");
    //    }


    public partial class EquipoBaseball : Form
    {
        static ClaseArregloDesordenado EquipoDeBaseball = new ClaseArregloDesordenado(2);
        ClaseDatos Jugador = new ClaseDatos();
        int indice;

        public EquipoBaseball()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            Jugador.Uniforme = Convert.ToUInt16(textBox1.Text);
            Jugador.Nombre = textBox1.Text;
            Jugador.Porcentaje = Convert.ToDouble(textBox3.Text);
            EquipoDeBaseball.Insertar(Jugador);
            MessageBox.Show("Jugador insertado en el arreglo:"
                + "\n*Núm.Uniforme: " + Jugador.Uniforme
                + "\n*Nombre: " + Jugador.Nombre
                + "\n*Porcentaje de Bateo: " + Jugador.Porcentaje, "Inserción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.Rows.Add(Jugador.Uniforme, Jugador.Nombre, Jugador.Porcentaje);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            EquipoDeBaseball.Ordenar();
            this.dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Ascending);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EquipoDeBaseball.Mayor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Jugador.Uniforme = Convert.ToUInt16(textBox1.Text);
            EquipoDeBaseball.Eliminar(Jugador.Uniforme);
            if (indice != -1)
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            MessageBox.Show("El jugador fue eliminado!");
        }
    }

}
