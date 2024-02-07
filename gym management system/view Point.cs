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
    public partial class view_Point : Form
    {
        public view_Point()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (search1.Text != "")
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\smart\\Documents\\fitneesDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from EquipmentTbl Where EId = " + search1.Text + "";
                cmd.Parameters.AddWithValue("@EId", search1.Text);
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                Da.Fill(ds, "EquipmentTbl");


                dataGridView1.DataSource = ds.Tables["EquipmentTbl"];
            }
            else
            {
                MessageBox.Show("please entry the id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
