using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_information.Resturant.AnalysisResturant
{
    public partial class Analysis_Resturant_Report : Form
    {
        public Analysis_Resturant_Report()
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
            Analysis_JanR analysis_JanR = new Analysis_JanR();
            analysis_JanR.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Analysis_FebR analysis_FebR = new Analysis_FebR();
            analysis_FebR.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Analysis_MarR analysis_MarR = new Analysis_MarR();
            analysis_MarR.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Analysis_AprR analysis_AprR = new Analysis_AprR();
            analysis_AprR.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Analysis_MayR analysis_MayR = new Analysis_MayR();
            analysis_MayR.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Analysis_JunR analysis_JunR = new Analysis_JunR();
            analysis_JunR.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Analysis_JulR analysis_JulR = new Analysis_JulR();
            analysis_JulR.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Analysis_AugR analysis_AugR = new Analysis_AugR();
            analysis_AugR.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Analysis_SepR analysis_SepR = new Analysis_SepR();
            analysis_SepR.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Analysis_OctR analysis_OctR = new Analysis_OctR();
            analysis_OctR.Show();
            this.Hide();
        }

        

        private void label14_Click(object sender, EventArgs e)
        {
            Analysis_DecR analysis_DecR = new Analysis_DecR();
            analysis_DecR.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Analysis_NovR analysis_NovR = new Analysis_NovR();
            analysis_NovR.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Summary_Resturant summary_Resturant = new Summary_Resturant();
            summary_Resturant.Show();
            this.Hide();
        }
    }
}
