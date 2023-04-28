using Hotel_information.AnalysisHotel;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Hotel_information
{
    public partial class Analysis_Jan : Form
    {
        public Analysis_Jan()
        {
            InitializeComponent();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mostafa\Downloads\information_Hotel-master\Hotel information\Database1.mdf"";Integrated Security=True");

        private void FeatchBTN_Click(object sender, EventArgs e)
        {
            double totin = 0.0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totin += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            label4.Text = totin.ToString();
        }
        private void Populate()
        {

            Con.Open();
            string query = "select * from Total_JanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Month_Report_Analysis home_Hotel_Page = new Month_Report_Analysis();
            home_Hotel_Page.Show();
            this.Hide();
        }
    }
}
