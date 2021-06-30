using System;
using System.Collections.Generic;
using System.Drawing;
using _002b_Libreria.Formas;
using System.Windows.Forms;

namespace _002b_Libreria.PanelDeDibujo
{
    public partial class Dibujo : Form
    {
        /*List<Formas.Formas> dibujos = new List</Formas.Formas>();*/

        int forma = 0;//1 Linea,2 Rectangulo, 3 Circulo        
        Graphics grPanel;
        Pen pen;
        Color ColorBorrado = Color.White;
        bool mouseDown = false;
        List<Formas.Formas> formas;
        Formas.Formas formaG;

        public Dibujo()
        {
            InitializeComponent();
            CB_Color.SelectedIndex = 0;
            CB_Grosor.SelectedIndex = 0;
            grPanel = this.Panel.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            formas = new List<Formas.Formas>();//instancio la lista de formas

        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            LB_Coordenada.Text = "";
        }

        private void Panel_MouseHover(object sender, EventArgs e)
        {

        }

        private void Dibujar()
        {

            foreach (var dibujo in formas)
            {
                dibujo.Dibujar(grPanel);//Polimorfismo
            }
            formaG.Pluma = pen;
            formaG.Dibujar(grPanel);
            //if (RB_Linea.Checked)
            //{
            //    grPanel.DrawLine(pen, p1, p2);
            //}
            //if (RB_Rectangulo.Checked)
            //{
            //    //toDo
            //}
        }
        private void RB_Linea_CheckedChanged(object sender, EventArgs e)
        {
            LB_Forma.Text = "Línea";
        }

        private void RB_Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            LB_Forma.Text = "Rectángulo";
        }

        private void RB_Elipse_CheckedChanged(object sender, EventArgs e)
        {
            LB_Forma.Text = "Elipse";
        }
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            //LB_Coordenada.Text = "Entro al panel";
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            LB_MouseDownLocation.Text = e.Location.ToString();
            //p1 = e.Location;
            mouseDown = true;
            if (RB_Linea.Checked)
            {
                formaG = new Linea();//Polimorfismo
            }
            if (RB_Rectangulo.Checked)
            {
                formaG = new Rectangulo();//Polimorfismo
            }
            if (RB_Elipse.Checked)
            {
                formaG = new Elipse();
            }
            formaG.P1 = e.Location;

        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            LB_Coordenada.Text = e.Location.ToString();
            int grosor=0;
            int.TryParse(CB_Grosor.SelectedItem.ToString(), out grosor);
            if (mouseDown)
            {
                if (!PuntoVacio(formaG.P1))
                {
                    if (!PuntoVacio(formaG.P2))
                    {
                        pen = new Pen(ColorBorrado, grosor);
                        Dibujar();
                    }
                    formaG.P2 = e.Location;
                    #region Nueva                           
                    pen = new Pen(GetColor(CB_Color.SelectedItem), grosor);
                    Dibujar();
                    #endregion
                }

            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            LB_MouseUpLocation.Text = e.Location.ToString();

            formaG.P2 = e.Location;
            int grosor;
            int.TryParse(CB_Grosor.SelectedItem.ToString(), out grosor);
            pen = new Pen(GetColor(CB_Color.SelectedItem), grosor);
            formaG.Pluma = pen;
            formas.Add(formaG);
            Dibujar();
            mouseDown = false;
            

        }

        private Color GetColor(Object color) 
        {
            switch (color)
            {
                case "Negro": return Color.Black;
                case "Verde": return Color.Green;
                case "Rojo": return Color.Red;
                case "Azul": return Color.Blue;
                case "Amarillo": return Color.Yellow;
                default: return Color.Black;
            }
        }

        private bool PuntoVacio(Point punto)
        {
            return (punto.X == -1 && punto.Y == -1);
        }


    }
}
