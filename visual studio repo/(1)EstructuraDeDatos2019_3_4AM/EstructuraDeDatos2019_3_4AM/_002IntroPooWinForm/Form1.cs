using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librerias.ClaseArreglo;
using Librerias.SortAlgorithms;

namespace _002IntroPooWinForm
{
    public partial class Form1 : Form
    {
        ClaseArregloDesordenadoDatos arreglo;

        public Form1()
        {
            InitializeComponent();

            arreglo = new ClaseArregloDesordenadoDatos(5);
            dataGridView1.DataSource = arreglo.Mostrar();


        }

        private void RefrescarArreglo() {
            dataGridView1.DataSource = arreglo.Mostrar();//muestra la info
            textBoxNombre.Text = "";
            textBoxNumero.Text = "";
            textBoxPorcentaje.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public bool HayDatos()
        {
            if (textBoxNombre.Text != ""&&textBoxNumero.Text != ""&&textBoxPorcentaje.Text!="")
            {
                return true;
            }

            return false;
        }

        private void ButtonInsertar_Click(object sender, EventArgs e)
        {
            if (HayDatos())
            {
                Datos datos = new Datos();

                datos.Nombre = textBoxNombre.Text;//asignamos nombre
                int.TryParse(textBoxNumero.Text, out int num);//asignamos num. de uniforme
                datos.NumUniforme = num;
                double.TryParse(textBoxPorcentaje.Text, out double porcentaje);//asignamos porcentaje de bateo
                datos.Porcentaje = porcentaje;


                if (arreglo.Insertar(datos))
                {

                    string texto = "";
                    texto = "El numero de jugador es: " + textBoxNumero.Text + "\n";
                    texto += "El nombre del jugador es: " + textBoxNombre.Text + "\n";
                    texto += "El porcentaje de bateo es: " + textBoxPorcentaje.Text + "\n";

                    RefrescarArreglo();
                    MessageBox.Show(texto);

                }
                else
                {
                    MessageBox.Show("Error al insertar :(");
                }
            }
            else
            {
                MessageBox.Show("Error, ingrese toda la informacion");
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (HayDatos())
            {
                Datos datos = new Datos();

                datos.Nombre = textBoxNombre.Text;//asignamos nombre
                int.TryParse(textBoxNumero.Text, out int num);//asignamos num. de uniforme
                datos.NumUniforme = num;
                double.TryParse(textBoxPorcentaje.Text, out double porcentaje);//asignamos porcentaje de bateo
                datos.Porcentaje = porcentaje;


                if (arreglo.Eliminar(datos))
                {

                    string texto = "Se elimino\n";
                    texto = "El numero de jugador es: " + textBoxNumero.Text + "\n";
                    texto += "El nombre del jugador es: " + textBoxNombre.Text + "\n";
                    texto += "El porcentaje de bateo es: " + textBoxPorcentaje.Text + "\n";

                    RefrescarArreglo();
                    MessageBox.Show(texto);

                }
                else
                {
                    MessageBox.Show("Error al eliminar :(");
                }
            }
            else
            {
                MessageBox.Show("Error, ingrese toda la informacion");
            }
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Clic en la celda");
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];


            //en base a las propiedades de la libreria Arreglos
            int uniforme = Convert.ToInt32(selectedRow.Cells["NumUniforme"].Value);
            string nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
            double porcentaje = Convert.ToDouble(selectedRow.Cells["Porcentaje"].Value);

            textBoxNombre.Text = nombre;
            textBoxNumero.Text = uniforme.ToString();
            textBoxPorcentaje.Text = porcentaje.ToString();

        }

        private void ButtonMejor_Click(object sender, EventArgs e)
        {
            if (!arreglo.EstaVacio())
            {
                dataGridView1.DataSource = arreglo.ObtenerMayor();
            }
        }
        public void RefrescarData()
        {
            dataGridView1.DataSource = arreglo.Mostrar();
            textBoxNombre.Text = "";
            textBoxNumero.Text = "";
            textBoxPorcentaje.Text = "";
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarData();
        }

        private void ButtonOrdenar_Click(object sender, EventArgs e)
        {
            BubbleSort.RunSort(arreglo);
            RefrescarData();

        }
    }
}
