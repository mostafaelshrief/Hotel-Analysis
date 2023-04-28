using Microsoft.Data.SqlClient;
using System.Data;

namespace Hotel_information.AnalysisHotel
{
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            Populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mostafa\Downloads\information_Hotel-master\Hotel information\Database1.mdf"";Integrated Security=True");
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
        private void Populate()
        {

            Con.Open();
            string query = "select * from TotalTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Month_Report_Analysis analysis = new Month_Report_Analysis();
            analysis.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
