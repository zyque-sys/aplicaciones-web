using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using III_002ClienteServidor.Modelos;

namespace III_002ClienteServidor
{
    public partial class FormCliente : Form
    {
        Datos datos;
        public FormCliente()
        {
            InitializeComponent();
            datos = new Datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos.A = Convert.ToInt32(textBoxA.Text);
            datos.B = Convert.ToInt32(textBoxB.Text);
            labelResultado.Text = "El resultado de la suma es: " + datos.Suma();
        }
    }
}
