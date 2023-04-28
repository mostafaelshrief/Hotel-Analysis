using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_information.Resturant.ExpensesResturant
{
    public partial class Restureanr_Report_Expenses : Form
    {
        public Restureanr_Report_Expenses()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home_Resturant_Page home_Resturant = new Home_Resturant_Page();
            home_Resturant.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Jan_Expenses jan_Expenses = new Jan_Expenses();
            jan_Expenses.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Feb_Expenses feb_ = new Feb_Expenses();
            feb_.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Mar_Expenses mar_ = new Mar_Expenses();
            mar_.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Apr_Expenses apr_ = new Apr_Expenses();
            apr_.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            May_Expenses may_ = new May_Expenses();
            may_.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Jun_Expenses jun_Expenses = new Jun_Expenses();
            jun_Expenses.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Jul_Expenses jul_Expenses = new Jul_Expenses();
            jul_Expenses.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Aug_Expenses aug_Expenses = new Aug_Expenses();
            aug_Expenses.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Sep_Expenses sep_ = new Sep_Expenses();
            sep_.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Oct_Expenses oct_Expenses = new Oct_Expenses();
            oct_Expenses.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Nov_Expenses nov_ = new Nov_Expenses();
            nov_.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Dec_Expenses dec_ = new Dec_Expenses();
            dec_.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Resturant_Expenses_Summary resturant_Expenses_Report = new Resturant_Expenses_Summary();
            resturant_Expenses_Report.Show();
            this.Hide();
        }
    }
}
