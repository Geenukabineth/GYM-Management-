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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gym_management_system
{
    public partial class supervision_coaching : Form
    {

        public supervision_coaching()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string fname = textBox6.Text;
            string lname = textBox2.Text;
            string email = textBox9.Text;
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
            string DOB = DOBTb.Text;
            string address = textBox3.Text;
            Int64 Exprience = Int64.Parse(textBox5.Text);
            Int64 Pnumber = Int64.Parse(textBox4.Text);
            string Designation = textBox1.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\smart\\Documents\\fitneesDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into SupervisioncoachesTbl(SFName,SLName,SDOB,SGender,SAdress,SDesignation,SCNumber,SExperience,SEmail)values('" + fname + " ','" + lname + " ','" + email + " ','" + gender + " ','" + DOB + " ','" + address + "','" + Exprience + "','" + Pnumber + "','" + Designation + ")";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();


            MessageBox.Show("completed");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox2.Clear();
            textBox9.Clear();
            radioButton1.Checked = false; radioButton2.Checked = false;
            DOBTb.Value = DateTime.Now;
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox1.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            coaches_view coaches_View = new coaches_view();
            coaches_View.Show();
            this.Hide();
        }
    }
}
