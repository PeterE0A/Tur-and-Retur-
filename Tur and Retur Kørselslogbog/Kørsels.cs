using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tur_and_Retur_Kørselslogbog
{
    public partial class Kørsels : Form
    {
        public Kørsels()
        {
            InitializeComponent();
        }

        private void laber1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Main_menu().Show();
            this.Hide();
        }

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from UserData1 full join kørselslogData on UserData1.NumberPlate = kørselslogData.NumberPlate", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        public void cc()
        {
            BindData();

            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");

            user_id.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserData1 full join kørselslogData on UserData1.NumberPlate = kørselslogData.NumberPlate";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                user_id.Items.Add(dr["user_id"]).ToString();
            }

            con.Close();
        }




        private void user_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindData();

            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserData1 full join kørselslogData on UserData1.NumberPlate = kørselslogData.NumberPlate where User_Id = '" + user_id.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                user_id.Text = dr["User_Id"].ToString();
                NumberPlate.Text = dr["NumberPlate"].ToString();
                Opgavetxt.Text = dr["Opgave"].ToString();


            }

            con.Close();

        }



        private void Kørsels_Load(object sender, EventArgs e)
        {
            cc();
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            if (NumberPlate.Text == "")
            {
                MessageBox.Show("Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
                con.Open();
                string insert = "insert into kørselslogData (NumberPlate, Opgave) VALUES ('" + NumberPlate.Text + "','" + Opgavetxt.Text + "') "; 
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();


                NumberPlate.Text = "";
                Opgavetxt.Text = "";



                MessageBox.Show("You Have Successfully Added an Opgave", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindData();
                cc();

            }


        }

        private void opgave_Click(object sender, EventArgs e)
        {

        }

        private void opgave1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            con.Open();

            string Update = "update kørselslogData set Opgave = '" + Opgavetxt.Text + "' where NumberPlate = '" + NumberPlate.Text + "' ";
            SqlCommand command = new SqlCommand(Update, con);

            command.ExecuteNonQuery();
            con.Close();






            
            NumberPlate.Text = "";
            Opgavetxt.Text = "";


            MessageBox.Show("You Have Successfully Updated Opgave", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            con.Open();

            string Delete = "delete from kørselslogData where NumberPlate = '" + NumberPlate.Text + "' ";
            SqlCommand command = new SqlCommand(Delete, con);

            command.ExecuteNonQuery();
            con.Close();






            
            NumberPlate.Text = "";
            Opgavetxt.Text = "";


            MessageBox.Show("You Have Successfully Deleted Opgave", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindData();
            cc();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from UserData1 full join kørselslogData on UserData1.NumberPlate = kørselslogData.NumberPlate where User_Id = '" + user_id.SelectedItem.ToString() + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
