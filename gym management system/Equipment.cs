using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace gym_management_system
{
    public partial class Equipment : Form
    {
        public Equipment()
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
            string NameofPurchase = textBox6.Text;
            Int64 cost = Int64.Parse(textBox2.Text);
            string Purchasedate = pdate.Text;
            string Pcompany = comboBox1.Text;
            string Description = textBox3.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\smart\\Documents\\fitneesDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into EquipmentTbl(ENOP,ECost,EPCompany,EPDate,EDescription)values ('" + NameofPurchase + " ','" + cost + " ','" + Purchasedate + " ','" + Pcompany + " ','" + Description + ")";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            MessageBox.Show("completed");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            label8.Text = "";
            textBox6.Clear();
            comboBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_Point view_Point = new view_Point();
            view_Point.Show();
            this.Hide();
        }
    }
}
