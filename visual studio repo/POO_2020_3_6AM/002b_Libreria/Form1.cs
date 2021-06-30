
using System.Drawing;
using System.Windows.Forms;

namespace _002b_Libreria
{
    public partial class Form1 : Form
    {
        Graphics grForm;
        Graphics grPanel;
        public Form1()
        {
            InitializeComponent();
            grForm = this.CreateGraphics();
            grPanel = this.PanelDeDibujo.CreateGraphics();
        }
        private void ImageExampleForm_Paint(object sender, PaintEventArgs e)
        {
            
            //// Create image.
            //Image newImage = Image.FromFile("Imagenes/babyFox.png");

            //// Create Point for upper-left corner of image.
            //Point ulCorner = new Point(100, 100);

            //// Draw image to screen.
            //e.Graphics.DrawImage(newImage, ulCorner);
            //gr = e.Graphics;
        }

        private void BT_Linea_Click(object sender, System.EventArgs e)
        {
            int x1 = int.Parse(TB_X1.Text);
            int y1 = int.Parse(TB_Y1.Text);

            int x2 = int.Parse(TB_X2.Text);
            int y2 = int.Parse(TB_Y2.Text);
            Point p1 = new Point(x1,y1);
            Point p2 = new Point(x2, y2);
            
            Pen pen = new Pen(Color.Black);//creamos pluma de color negro con un pixel de grosor
            grPanel.DrawLine(pen,p1,p2);
        }
    }
}
