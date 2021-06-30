using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _004_LoginEncrypt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\leder\source\repos\PWEB_2021_1\DB\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
        private void BT_loginingreesar_Click(object sender, EventArgs e)
        {
           
                string password = "";
                bool existe = false;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Login where usuario='" + TB_loginusuario.Text + "'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    password = sdr.GetString(2);
                    existe = true;
                }
                con.Close();
                if (existe)
                {
                if (Cryptography.Decrypt(password).Equals(TB_logincontrasenha.Text))
                {
                    MainScrn objFrmMain = new MainScrn();
                    this.Hide();
                    objFrmMain.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                }
                else  
                {
                    MessageBox.Show("Credenciales incorrectas", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void BT_Register_Click(object sender, EventArgs e)
        {
            Form1 objRegister = new Form1();
             this.Hide();
            objRegister.Show();
        }

     
    }
}
