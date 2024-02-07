namespace gym_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {


            memberships nm = new memberships();
            nm.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

            Billing nm = new Billing();
            nm.Show();
            this.Hide();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

            supervision_coaching supervision_Coaching = new supervision_coaching();
            supervision_Coaching.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {

            member member = new member();
            member.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            loging loging = new loging();
            loging.Show();
            this.Hide();
        }
    }
}