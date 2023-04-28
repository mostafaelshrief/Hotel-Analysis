namespace Hotel_information.InComeBackView
{
    public partial class Month_Report_BackView : Form
    {
        public Month_Report_BackView()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            BackView_Jan backViewRoom = new BackView_Jan();
            backViewRoom.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BackView_Feb backViewRoom = new BackView_Feb();
            backViewRoom.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BackView_Mar backViewRoom = new BackView_Mar();
            backViewRoom.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BackView_Apr backViewRoom = new BackView_Apr();
            backViewRoom.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BackView_May backViewRoom = new BackView_May();
            backViewRoom.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            BackView_Jun backViewRoom = new BackView_Jun();
            backViewRoom.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            BackView_Jul backViewRoom = new BackView_Jul();
            backViewRoom.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            BackView_Aug backViewRoom = new BackView_Aug();
            backViewRoom.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            BackView_Sep backViewRoom = new BackView_Sep();
            backViewRoom.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            BackView_Oct backViewRoom = new BackView_Oct();
            backViewRoom.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            BackView_Nov backViewRoom = new BackView_Nov();
            backViewRoom.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            BackView_Dec backViewRoom = new BackView_Dec();
            backViewRoom.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            IcomeRooms icome = new IcomeRooms();
            icome.Show();
            this.Hide();
        }
    }
}
