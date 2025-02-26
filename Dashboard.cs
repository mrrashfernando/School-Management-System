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

namespace schoolmanagement02
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            display();
            display1();
            display2();
            display3();
        }
        private void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS02;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM studentab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount.Text = "0";
            }
            con.Close();
        }
        private void display1()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS02;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM subtab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount1.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount1.Text = "0";
            }
            con.Close();
        }
        private void display2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS02;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM teachertab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount2.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount2.Text = "0";
            }
            con.Close();
        }
        private void display3()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS02;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM entab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount3.Text = "0";
            }
            con.Close();
        }

     
    }
}
