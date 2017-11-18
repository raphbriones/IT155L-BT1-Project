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
    public partial class AppLogin : Form
    {
        int num;
        public AppLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = 2;
            this.Hide();
            Home hm = new Home(num);
            hm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login appLogin = new Login();
            appLogin.Show();
        }

        private void AppLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
