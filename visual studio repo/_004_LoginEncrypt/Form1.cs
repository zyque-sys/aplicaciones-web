using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _004_LoginEncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=172.18.1.3;Initial Catalog=LoginDB;User ID=prog;Password=XqvF^D2$wJ");
        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leder\source\repos\PWEB_2021_1\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void BT_login_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=LoginDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //string query = "Select * from Login where usuario = '" + TB_usuario.Text.Trim() + "' and contrasenha= '" + TB_contrasenha.Text.Trim() + "'";
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //if (dtbl.Rows.Count == 1)
            //{
            //    MainScrn objFrmMain = new MainScrn();
            //    this.Hide();
            //    objFrmMain.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o Contraseña incorrectos");
            //}


            if (TB_usuario.Text != "" && TB_contrasenha.Text != "" && TB_confirmarpw.Text != "")   
            {
                if (TB_contrasenha.Text.ToString().Trim().ToLower() == TB_contrasenha.Text.ToString().Trim().ToLower())    
                {
                    string userName = TB_usuario.Text;
                    string password = Cryptography.Encrypt(TB_contrasenha.Text.ToString());   
                    con.Open();
                    SqlCommand insert = new SqlCommand("insert into Login(usuario,contrasenha)values('" + userName + "','" + password + "')", con);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("El usuario ha sido registrado", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login objFrmlogin = new Login();
                    this.Hide();
                    objFrmlogin.Show();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden...", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                }
            }
            else
            {
                MessageBox.Show("Llena todos los campos!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            
        }
    
    }
}
