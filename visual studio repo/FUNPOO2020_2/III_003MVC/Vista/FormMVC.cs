using System;
using System.Collections.Generic;

using System.Windows.Forms;
using III_003MVC.Control;

namespace III_003MVC
{
    public partial class FormMVC : Form
    {
        ControlDeOperaciones control;
        public FormMVC()
        {
            InitializeComponent();
            control = new ControlDeOperaciones();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            control.CargarA(Convert.ToInt32(textBoxA.Text));
            control.CargarB(Convert.ToInt32(textBoxB.Text));

            labelResultado.Text = "El resultdo de la suma es: " + control.Suma();

        }
    }
}
