using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restovatev3
{
    public partial class ShowDescription : Form
    {
        int itemid;
        int id;
 
        public ShowDescription(int itemid, int id)
        {
            this.itemid = itemid;
            this.id = id;
            InitializeComponent();
        }

        private void ShowDescription_Load(object sender, EventArgs e)
        {
            SqlDataReader rdr = null;
            string constring;
            constring = "Data Source=(local);Initial Catalog=RestovateDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            string cmdText = "Select * from ItemDescript where ItemID = " + itemid;
            SqlCommand cmd = new SqlCommand(cmdText,con);

            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string prodname = (string)rdr["ProdName"];
                    string prodtype = (string)rdr["ProdType"];
                    string proddescript = (string)rdr["ProdDescript"];


                    this.Text = prodname;
                    this.label1.Text = prodname;
                    this.label2.Text = prodtype;
                    this.label3.Text = proddescript;
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                this.Close();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else if (id==1)
            {
                this.Close();
                Form4 frm4 = new Form4();
                frm4.Show();
            }
            
        }
    }
}
