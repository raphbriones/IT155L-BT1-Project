using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restovatev3
{
    public partial class Form4 : Form
    {
        int itemid;
        int id;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1006;
            id = 1;
            ShowDescription frm3 = new ShowDescription(itemid,id);
            frm3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Home frm1 = new Home();
            frm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1007;
            id = 1;
            ShowDescription frm3 = new ShowDescription(itemid, id);
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1008;
            id = 1;
            ShowDescription frm3 = new ShowDescription(itemid, id);
            frm3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1011;
            id = 1;
            ShowDescription frm3 = new ShowDescription(itemid, id);
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1009;
            id = 1;
            ShowDescription frm3 = new ShowDescription(itemid, id);
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1010;
            id = 1;
            ShowDescription frm3 = new ShowDescription(itemid, id);
            frm3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1012;
            id = 1;
            ShowDescription frm3 = new ShowDescription(itemid, id);
            frm3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemid = 1013;
            id = 1;
            ShowDescription frm3 = new ShowDescription(itemid, id);
            frm3.Show();
        }
    }
}
