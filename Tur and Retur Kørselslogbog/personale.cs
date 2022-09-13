using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        DataIO data = new DataIO();
        CRUD crud = new CRUD();




        private void personale_Load(object sender, EventArgs e)
        {

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
            
            DataIO newCustomer = new DataIO();
            newCustomer.insert(FirstName.Text, LastName.Text, Email.Text, Telephone.Text, NumberPlate.Text);
        }
    }
}
