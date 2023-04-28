using Hotel_information.ExpensesFolder;
using Hotel_information.Resturant.AnalysisResturant;
using Hotel_information.Resturant.ExpensesResturant;
using Hotel_information.Resturant.IncomeRestutant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_information.Resturant
{
    public partial class Home_Resturant_Page : Form
    {
        public Home_Resturant_Page()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Report_Income report_Income = new Report_Income();
            report_Income.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Report_Income report_Income = new Report_Income();
            report_Income.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Restureanr_Report_Expenses month_Report = new Restureanr_Report_Expenses();
            month_Report.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Restureanr_Report_Expenses month_Report = new Restureanr_Report_Expenses();
            month_Report.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Analysis_Resturant_Report analysis_Resturant_Report = new Analysis_Resturant_Report();
            analysis_Resturant_Report.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Analysis_Resturant_Report analysis_Resturant_Report = new Analysis_Resturant_Report();
            analysis_Resturant_Report.Show();
            this.Hide();
        }
    }
}
