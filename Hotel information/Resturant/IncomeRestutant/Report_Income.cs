using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_information.Resturant.IncomeRestutant
{
    public partial class Report_Income : Form
    {
        public Report_Income()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home_Resturant_Page home_Resturant_Page = new Home_Resturant_Page();
            home_Resturant_Page.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Jan_Income jan_Income = new Jan_Income();
            jan_Income.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Feb_Income feb_Income = new Feb_Income();
            feb_Income.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Mar_Income mat_Income = new Mar_Income();
            mat_Income.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Apr_Income apr_Income = new Apr_Income();
            apr_Income.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            May_Income may_Income = new May_Income();
            may_Income.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Jun_Income jun_Income = new Jun_Income();
            jun_Income.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Jul_Income jul_Income = new Jul_Income();
            jul_Income.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Aug_Income aug_Income = new Aug_Income();
            aug_Income.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Sep_Income sep_Income = new Sep_Income();
            sep_Income.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Oct_income oct_Income = new Oct_income();
            oct_Income.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Nov_Income nov_Income = new Nov_Income();
            nov_Income.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Dec_Income dec_Income = new Dec_Income();
            dec_Income.Show();
            this.Hide();
        }
    }
}
