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
    public partial class HMap : Form
    {
        public HMap()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            this.Close();
            frm.Show();
        }
    }
}
