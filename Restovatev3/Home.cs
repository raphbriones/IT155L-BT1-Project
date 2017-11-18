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
    public partial class Home : Form
    {
        public Home()
        {
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

        private void button6_Click(object sender, EventArgs e)
        {
            HMap hmap = new HMap();
            this.Hide();
            hmap.Show();
        }
    }
}
