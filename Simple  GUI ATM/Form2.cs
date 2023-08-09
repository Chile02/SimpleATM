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

namespace Simple__GUI_ATM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int balance = 0;

        private void signUpbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=AtmDB;Integrated Security=True");

            if (nameBox.Text == "" || lnameBox.Text == "" || regPinBox.Text == "" || addressBox.Text == "")
            {
                MessageBox.Show("Fill in all the details");
            }
            else
            {
                try
                {
                    con.Open();
                    string query1 = "insert into Userdetails values('" + accInpBox.Text + "', '" + nameBox.Text + "', '" + lnameBox.Text + "', '" + comboBox1.SelectedItem.ToString() + "', '" + sexComboBox.SelectedItem.ToString() + "', '" + dateTimePicker1.Value.Date + "', '" + addressBox.Text + "', '" + balance + "', '" + regPinBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully");
                    con.Close();
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }


            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
