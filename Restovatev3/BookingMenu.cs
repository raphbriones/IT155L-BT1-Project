﻿using System;
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
    public partial class BookingMenu : Form
    {
        public BookingMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingTable booking = new BookingTable();
            this.Hide();
            booking.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();

        }
    }
}
