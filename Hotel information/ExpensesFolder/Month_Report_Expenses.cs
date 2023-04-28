using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_information.ExpensesFolder
{
    public partial class Month_Report_Expenses : Form
    {
        public Month_Report_Expenses()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home_Hotel_Page home_Hotel_Page = new Home_Hotel_Page();
            home_Hotel_Page.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Expenses_Jan expenses_Jan = new Expenses_Jan();
            expenses_Jan.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expenses_Feb expenses_Feb = new Expenses_Feb();
            expenses_Feb.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Expenses_Mar expenses_Mar = new Expenses_Mar();
            expenses_Mar.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Expenses_Apr expenses_Apr = new Expenses_Apr();
            expenses_Apr.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Expenses_May expenses_May = new Expenses_May();
            expenses_May.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Expenses_Jun expenses_Jun = new Expenses_Jun();
            expenses_Jun.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Expenses_Jul expenses_Jul = new Expenses_Jul();
            expenses_Jul.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Expenses_Aug expenses_Aug = new Expenses_Aug();
            expenses_Aug.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Expenses_Sep expenses_Sep = new Expenses_Sep();
            expenses_Sep.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Expenses_Oct expenses_Oct = new Expenses_Oct();
            expenses_Oct.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Expenses_Nov expenses_Nov = new Expenses_Nov();
            expenses_Nov.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Expenses_Dec expenses_Dec = new Expenses_Dec();
            expenses_Dec.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            TheRopert theRopert = new TheRopert();
            theRopert.Show();
            this.Hide();
        }
    }
}
