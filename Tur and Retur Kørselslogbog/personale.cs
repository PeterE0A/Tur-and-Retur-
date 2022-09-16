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


namespace Tur_and_Retur_Kørselslogbog
{
    public partial class personale : Form
    {
        public personale()
        {
            InitializeComponent();
        }


        //DataIO data = new DataIO();
        //CRUD crud = new CRUD();




        private void personale_Load(object sender, EventArgs e)
        {
            cc();

           
        }


        public void cc()
        {
            BindData();
        
            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");

            user_id.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserData1";
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

        private void button5_Click(object sender, EventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Main_menu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "" && LastName.Text == "" && Email.Text == "" && Telephone.Text == "" && NumberPlate.Text == "")
            {
                MessageBox.Show("Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
                con.Open();
                string ADD = "INSERT INTO UserData1 (FirstName, LastName, Email, Telephone, Date, NumberPlate) VALUES ('" + FirstName.Text + "', '" + LastName.Text + "', '" + Email.Text + "', '" + Telephone.Text + "',  '" + this.dateTime.Text + "', '" + NumberPlate.Text + "')";
                SqlCommand cmd = new SqlCommand(ADD, con);
                cmd.ExecuteNonQuery();
                con.Close();
               

                FirstName.Text = "";
                LastName.Text = "";
                Email.Text = "";
                Telephone.Text = "";
                NumberPlate.Text = "";


                MessageBox.Show("You Have Successfully Added a New User", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindData();
                cc();

            }
    

            

        }

        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            SqlCommand command = new SqlCommand("select * from UserData1", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            con.Open();

            string Update = "update UserData1 set FirstName = '" + FirstName.Text + "',LastName = '" + LastName.Text + "',Email = '" + Email.Text + "',Telephone = '" + Telephone.Text + "',Date =  '" + dateTime.Text + "',NumberPlate = '" + NumberPlate.Text + "' where User_Id = '" + user_id.Text + "' ";
            SqlCommand command = new SqlCommand(Update,con);
                
                command.ExecuteNonQuery();
                con.Close();






            FirstName.Text = "";
            LastName.Text = "";
            Email.Text = "";
            Telephone.Text = "";
            NumberPlate.Text = "";


            MessageBox.Show("You Have Successfully Updated User", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindData();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            BindData();

            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");

            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from UserData1 where User_Id = '" + user_id.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                FirstName.Text = dr["FirstName"].ToString();
                LastName.Text = dr["LastName"].ToString();
                Email.Text = dr["Email"].ToString();
                Telephone.Text = dr["Telephone"].ToString();
                this.dateTime.Text = dr["Date"].ToString();
                NumberPlate.Text = dr["Numberplate"].ToString();



            }

            con.Close();


            //SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            //con.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM UserData1 where User_Id = '"+user_id.Text+"'",con);
            //command.ExecuteNonQuery();
            //SqlDataReader dr;
            //dr = command.ExecuteReader();

            //string userid = user_id.Text;
            //user_id.Items.Add(userid);

            //while (dr.Read())
            //{
            //    string firstname = (string)dr["FirstName"].ToString();
            //    FirstName.Text = firstname;

            //    string lastname = (string)dr["LasttName"].ToString();
            //    LastName.Text = lastname;

            //    string email = (string)dr["Email"].ToString();
            //    Email.Text = email;

            //    string telephone = (string)dr["Telephone"].ToString();
            //    Telephone.Text = telephone;

            //    string numberplate = (string)dr["NumberPlate"].ToString();
            //    NumberPlate.Text = numberplate;



            //}


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-C5D49FN17LD;Initial Catalog=Registeration;Integrated Security=True");
            con.Open();

            string Delete = "delete from UserData1 where User_Id = '" + user_id.Text + "' ";
            SqlCommand command = new SqlCommand(Delete, con);

            command.ExecuteNonQuery();
            con.Close();






            FirstName.Text = "";
            LastName.Text = "";
            Email.Text = "";
            Telephone.Text = "";
            NumberPlate.Text = "";


            MessageBox.Show("You Have Successfully Deleted User", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindData();
            cc();
        }
    }
}
