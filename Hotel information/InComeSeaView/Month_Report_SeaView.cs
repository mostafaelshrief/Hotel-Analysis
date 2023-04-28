using Hotel_information.InComeSeaView;

namespace Hotel_information
{
    public partial class Month_Report_SeaView : Form
    {
        public Month_Report_SeaView()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SeaView_May seaView_May = new SeaView_May();
            seaView_May.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SeaViewReom_Jan seaViewReom = new SeaViewReom_Jan();
            seaViewReom.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            IcomeRooms income = new IcomeRooms();
            income.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SeaView_Feb seaView_ = new SeaView_Feb();
            seaView_.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SeaView_Mar seaView_Mar = new SeaView_Mar();
            seaView_Mar.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            SeaView_Apr seaView_Apr = new SeaView_Apr();
            seaView_Apr.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            SeaView_Jun seaView_Jun = new SeaView_Jun();
            seaView_Jun.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            SeaView_Jul seaView_Jul = new SeaView_Jul();
            seaView_Jul.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            SeaView_Aug seaView_Aug = new SeaView_Aug();
            seaView_Aug.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            SeaView_Sep seaView_Sep = new SeaView_Sep();
            seaView_Sep.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            SeaView_Oct seaView_Oct = new SeaView_Oct();
            seaView_Oct.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            SeaView_Nov seaView_Nov = new SeaView_Nov();
            seaView_Nov.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            SeaView_Dec seaView_Dec = new SeaView_Dec();
            seaView_Dec.Show();
            this.Hide();
        }
    }
}
