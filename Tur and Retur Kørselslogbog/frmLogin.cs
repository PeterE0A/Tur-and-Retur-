using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Tur_and_Retur_Kørselslogbog
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            con.Open();
            string login = "SELECT * FROM tblUser WHERE username = '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new Main_menu().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                
            }
            else
            {
                txtpassword.PasswordChar = '*';
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
