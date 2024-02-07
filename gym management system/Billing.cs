using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_management_system
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            txtresult.Text += "*********************************************************************";
            txtresult.Text += "*********             power Fitnees  PVT LTD                *********";
            txtresult.Text += "***              32/25c,Maken mawatha, Colombo 3                  ***";
            txtresult.Text += "**       Mobile.N:0778789656/Email:powerfitnees.gmail,com          **";
            txtresult.Text += "*********************************************************************";
            txtresult.Text += "data :" + DateTime.Now + "\n\n";

            txtresult.Text += "Customer name:" + textBox1.Text + "\n\n";
            txtresult.Text += "Customer Id:" + textBox4.Text + "\n\n";
            txtresult.Text += "Mobile number:" + textBox3.Text + "\n\n";
            txtresult.Text += "Amount paid:" + textBox5.Text + "\n\n";
            txtresult.Text += "Balance:" + textBox6.Text + "\n\n";



            txtresult.Text += "\n      thank for your payment ";




        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            txtresult.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();



        }
    }
}

