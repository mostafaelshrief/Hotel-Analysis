namespace Hotel_information
{
    public partial class Home_Yacht_Page : Form
    {
        public Home_Yacht_Page()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Income_Yacht income_Yacht = new Income_Yacht();
            income_Yacht.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Income_Yacht income_Yacht = new Income_Yacht();
            income_Yacht.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Yacht_Expenses yacht_Expenses = new Yacht_Expenses();
            yacht_Expenses.Show();
            this.Hide();
        }
    }
}
