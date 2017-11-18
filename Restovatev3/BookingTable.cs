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
    public partial class BookingTable : Form
    {
        public BookingTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingMenu booking = new BookingMenu();
            this.Close();
            booking.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message");
            }
            
        }
    }
}
