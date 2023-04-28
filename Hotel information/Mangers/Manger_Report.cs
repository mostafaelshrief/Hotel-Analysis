using Hotel_information.AnalysisHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_information.Mangers
{
    public partial class Manger_Report : Form
    {
        public Manger_Report()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Mangers_Jan mangers_ = new Mangers_Jan();
            mangers_.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Mangers_Feb mangers_ = new Mangers_Feb();
            mangers_.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Mangers_Mar mangers_ = new Mangers_Mar();
            mangers_.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Mangers_Apr mangers_ = new Mangers_Apr();
            mangers_.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Mangers_May mangers_ = new Mangers_May();
            mangers_.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Mangers_Jun mangers_ = new Mangers_Jun();
            mangers_.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Mangers_Jul mangers_ = new Mangers_Jul();
            mangers_.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Mangers_Aug mangers_ = new Mangers_Aug();
            mangers_.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Mangers_Sep mangers_ = new Mangers_Sep();
            mangers_.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Mangers_Oct mangers_ = new Mangers_Oct();
            mangers_.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Mangers_Nov mangers_ = new Mangers_Nov();
            mangers_.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Mangers_Dec mangers_ = (new Mangers_Dec());
            mangers_.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Month_Report_Analysis month_Report_Analysis = new Month_Report_Analysis();
            month_Report_Analysis.Show();
            this.Hide();
        }
    }
}
