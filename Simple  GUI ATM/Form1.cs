using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple__GUI_ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
            this.Hide();
        }
        private static String accNum;
        
        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AtmDB;Integrated Security=True");

            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Userdetails where acc ='" + accBox.Text + "' and pin = '" + pinBox.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Incorrect pin or account number");
            }


        }
    }
}