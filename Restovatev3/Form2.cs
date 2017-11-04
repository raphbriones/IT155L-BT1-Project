using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Restovatev3
{
    public partial class Form2 : Form
    {
        int itemid; 
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1001;
            Form3 frm3 = new Form3(itemid);
            frm3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1005;
            Form3 frm3 = new Form3(itemid);
            frm3.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1002;
            Form3 frm3 = new Form3(itemid);
            frm3.Show();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1003;
            Form3 frm3 = new Form3(itemid);
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1004;
            Form3 frm3 = new Form3(itemid);
            frm3.Show();
        }
    }
}
