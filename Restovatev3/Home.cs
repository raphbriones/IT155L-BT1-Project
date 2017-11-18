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
    public partial class Home : Form
    {
        int num;
        public Home()
        {
            InitializeComponent();
        }
        public Home(int num)
        {
            this.num = num;
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BookingMenu booking = new BookingMenu();
            this.Hide();
            booking.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (num == 2)
            {
                label1.Text = "Welcome, Guest!";
            }
            else
            {
                /*
                string constring;
                string query;
                constring = "Data Source=(local);Initial Catalog=RestovateDatabase;Integrated Security=True";
                query = "";
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, constring);*/
            }
        }
    }
}
