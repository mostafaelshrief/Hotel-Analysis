using Hotel_information.AnalysisHotel;
using Hotel_information.ExpensesFolder;

namespace Hotel_information
{
    public partial class Home_Hotel_Page : Form
    {
        public Home_Hotel_Page()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            IcomeRooms income = new IcomeRooms();
            income.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Month_Report_Expenses expenses = new Month_Report_Expenses();
            expenses.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Month_Report_Analysis analysis = new Month_Report_Analysis();
            analysis.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Analysis_Jan analysis = new Analysis_Jan();
            analysis.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Month_Report_Expenses month_Report_Expenses = new Month_Report_Expenses();
            month_Report_Expenses.Show();
            month_Report_Expenses.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            IcomeRooms income = new IcomeRooms();
            income.Show();
            this.Hide();
        }
    }
}
