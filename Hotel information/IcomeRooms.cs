using Hotel_information.InComeBackView;
using Hotel_information.InComeCamp;

namespace Hotel_information
{
    public partial class IcomeRooms : Form
    {
        public IcomeRooms()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home_Hotel_Page home_Hotel_Page = new Home_Hotel_Page();
            home_Hotel_Page.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Month_Report_SeaView month_Report = new Month_Report_SeaView();
            month_Report.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Month_Report_SeaView month_Report = new Month_Report_SeaView();
            month_Report.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Month_Report_BackView backViewRoom = new Month_Report_BackView();
            backViewRoom.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Month_Report_BackView backViewRoom = new Month_Report_BackView();
            backViewRoom.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Month_Report_Camp campRoom = new Month_Report_Camp();
            campRoom.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Month_Report_Camp campRoom = new Month_Report_Camp();
            campRoom.Show();
            this.Hide();
        }
    }
}
