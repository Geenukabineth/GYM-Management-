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

namespace gym_management_system
{
    public partial class member : Form
    {
        public member()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\smart\\Documents\\fitneesDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select ' from MembershipTbl Where MShipId = " + textBox1.Text + "";
                cmd.Parameters.AddWithValue("@MShipId", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "MembershipTbll");





                dataGridView1.DataSource = ds.Tables["MembershipTbl"];


            }
            else
            {
                MessageBox.Show("please entry the id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
