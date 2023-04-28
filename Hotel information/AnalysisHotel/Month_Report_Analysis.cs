using Hotel_information.Mangers;

namespace Hotel_information.AnalysisHotel
{
    public partial class Month_Report_Analysis : Form
    {
        public Month_Report_Analysis()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Analysis_Jan analysis = new Analysis_Jan();
            analysis.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Analysis_Feb analysis = new Analysis_Feb();
            analysis.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Analysis_Mar analysis = new Analysis_Mar();
            analysis.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Analysis_Apr analysis = new Analysis_Apr();
            analysis.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Analysis_May analysis = new Analysis_May();
            analysis.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Analysis_Jun analysis = new Analysis_Jun();
            analysis.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Analysis_Jul analysis = new Analysis_Jul();
            analysis.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Analysis_Aug analysis = new Analysis_Aug();
            analysis.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Analysis_Sep analysis = new Analysis_Sep();
            analysis.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Analysis_Oct analysis = new Analysis_Oct();
            analysis.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Analysis_Nov analysis = new Analysis_Nov();
            analysis.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Analysis_Dec analysis = new Analysis_Dec();
            analysis.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home_Hotel_Page home_Hotel_Page = new Home_Hotel_Page();
            home_Hotel_Page.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Summary summary = new Summary();
            summary.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
