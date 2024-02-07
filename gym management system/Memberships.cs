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
    public partial class memberships : Form
    {
        public memberships()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox4.Text;
            string email = textBox7.Text;
            string gender = "";
            bool ischacked = radioButton1.Checked;
            if (ischacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string DOB = dateTimePicker4.Text;
            string address = textBox6.Text;
            Int64 pnumber = Int64.Parse(textBox3.Text);
            string Jb = dateTimePicker1.Text;
            string Et = dateTimePicker2.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\smart\\Documents\\fitneesDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into MembershipTbl(MFName, MLName,MDOB,MEmail,MPhone,MJD,MED,MAdress,MGender)values ('" + fname + " ','" + lname + " ','" + email + " ','" + gender + " ','" + DOB + " ','" + address + "','" + address + "','" + pnumber + "','" + Jb + "','" + Et + "','" + ")";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            
            MessageBox.Show("completed");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox7.Clear();
            radioButton1.Checked =false; radioButton2.Checked =false;
            textBox6.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
        }
    }
}
