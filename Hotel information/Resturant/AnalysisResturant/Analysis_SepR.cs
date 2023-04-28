using Microsoft.Data.SqlClient;
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
    public partial class Analysis_SepR : Form
    {
        public Analysis_SepR()
        {
            InitializeComponent();
        }

        private void Analysis_SepR_Load(object sender, EventArgs e)
        {
            Populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mostafa\Downloads\information_Hotel-master\Hotel information\Database1.mdf"";Integrated Security=True");
        private void Populate()
        {

            Con.Open();
            string query = "select * from Analysis_SepTblR";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        int totinrooms;
        int expenses;

        private void button1_Click(object sender, EventArgs e)
        {
            double totin = 0.0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totin += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            label4.Text = totin.ToString();
            for (int x = 1; x < dataGridView1.Rows.Count; x++)
            {
                totinrooms += Convert.ToInt32(dataGridView1.Rows[x].Cells[1].Value);
            }
            label6.Text = totinrooms.ToString();
            for (int x = 0; x < 1; x++)
            {
                expenses += Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value);
            }
            label8.Text = expenses.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Analysis_Resturant_Report analysis_Resturant_Report = new Analysis_Resturant_Report();
            analysis_Resturant_Report.Show();
            this.Hide();
        }
    }
}
