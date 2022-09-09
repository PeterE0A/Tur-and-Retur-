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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
        //SqlConnection cmd = new SqlConnection();
        //SqlConnection da = new SqlConnection();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                if (txtUsername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
                {
                    MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtpassword.Text == txtComPassword.Text)
                {
                conn.Open();
                string register = "INSERT INTO tblUser (username, password) VALUES ('" + txtUsername.Text + "', '" + txtpassword.Text + "')";
                SqlConnection cmd = new SqlConnection(register);
                conn.Close();

            }

          

        }
    }
}
