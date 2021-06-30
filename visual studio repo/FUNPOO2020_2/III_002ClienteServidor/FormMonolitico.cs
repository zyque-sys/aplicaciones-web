using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace III_002ClienteServidor
{
    public partial class FormMonolitico : Form
    {
        public FormMonolitico()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxA.Text);
            int b = Convert.ToInt32(textBoxB.Text);
            labelResultado.Text = "El resultado de la suma es: " + (a + b);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Pasé por encima";
        }

    }
}
