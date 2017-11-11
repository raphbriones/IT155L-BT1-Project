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

namespace Restovatev3
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring;
            //               string cmdtext1;
            //               cmdtext1 = "Update Account Set";
            constring = "Data Source = (local); Initial Catalog = RestovateDatabase; Integrated Security = True";
            SqlConnection connection = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("",connection);


            if (textBox5.Text == textBox6.Text)
            {
                
                connection.Open();
                cmd.CommandText = "INSERT INTO Account (FirstName, LastName, MobileNumber, Email, Password) VALUES (@FirstName, @LastName, @MobileNumber, @Email, @Password)";
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                cmd.Parameters.AddWithValue("@MobileNumber", textBox3.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@Password", textBox6.Text);


                cmd.CommandText = "INSERT INTO Login (Email, Password) VALUES (@Email, @Password)";
                cmd.Parameters["@Email"].Value = textBox4.Text;
                cmd.Parameters["@Password"].Value = textBox6.Text;
                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("You have successfully created an account!", "Message");
                this.Close();
                Login login = new Login();
                login.Show();

            }
            else
            {
                MessageBox.Show("Your confirm password does not match with the first password!","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
