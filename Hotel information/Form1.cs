using Hotel_information.Resturant;

namespace Hotel_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home_Hotel_Page home_Hotel = new Home_Hotel_Page();
            home_Hotel.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home_Hotel_Page home_Hotel = new Home_Hotel_Page();
            home_Hotel.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Home_Yacht_Page home_Yacht = new Home_Yacht_Page();
            home_Yacht.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home_Yacht_Page home_Yacht = new Home_Yacht_Page();
            home_Yacht.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Home_Resturant_Page home_Resturant_Page = new Home_Resturant_Page();
            home_Resturant_Page.Show();
            this.Hide();
        }
    }
}