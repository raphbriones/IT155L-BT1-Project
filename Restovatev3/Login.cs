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
using System.Data.Sql;

namespace Restovatev3
{
    public partial class Login : Form
    {
        int num;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AppLogin appLogin = new AppLogin();
            appLogin.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constring;
                string query;
                constring = "Data Source=(local);Initial Catalog=RestovateDatabase;Integrated Security=True";
                SqlConnection con = new SqlConnection(constring);
                query = "select *from Login where Email = '" + textBox1.Text +
                    "' AND Password = '" + textBox2.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, constring);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                DataRow[] dataRow;
                dataRow = dataTable.Select();

                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("You have successfully logged in!", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    num = 1;
                    Home hme = new Home(num);
                    hme.Show();
                }
                else
                {
                    MessageBox.Show("Your Email Address or Password is incorrect!", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }
    }
}
