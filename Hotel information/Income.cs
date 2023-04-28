using Microsoft.Data.SqlClient;
using System.Data;

namespace Hotel_information
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\source\repos\Hotel information\Hotel information\Database1.mdf;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            String query = "select * from BookingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Income_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RoomTb.Text == "" || PriceTb.Text == "" || DayTb.Text == "" ||
               DateDTP.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                int totalprice;
                string strTotal;
                totalprice = Convert.ToInt32(PriceTb.Text) * Convert.ToInt32(DayTb.Text);
                strTotal = totalprice.ToString();
                PriceTotalLbl.Text = strTotal;
                Con.Open();
                String query = "insert into BookingTbl values(N'" + RoomTb.Text + "','" + PriceTb.Text + "','" + DayTb.Text + "','" + DateDTP.Value.ToString() + "','" + PriceTotalLbl.Text + "')";
                SqlCommand cmd = new SqlCommand("INSERT INTO BookingTbl (Room,Price,Days,Date,TotalPrice) VALUES " +
                    "(@Room,@Price,@Days,@Date,@TotalPrice)", Con);
                cmd.Parameters.AddWithValue("@Room", RoomTb.Text);
                cmd.Parameters.AddWithValue("@Price", PriceTb.Text);
                cmd.Parameters.AddWithValue("@Days", DayTb.Text);
                cmd.Parameters.AddWithValue("@Date", DateDTP.Text);
                cmd.Parameters.AddWithValue("@TotalPrice", PriceTotalLbl.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item successfully Added");

                Con.Close();
                populate();


            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 & e.Value != null)
            {
                int sum1 = Convert.ToInt32(e.Value);
                if (sum1 == 99)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 100)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 102)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 103)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 104)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 105)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 107)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 117)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 118)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 119)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 120)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 127)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 128)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 129)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 130)
                {
                    e.CellStyle.BackColor = Color.CornflowerBlue;
                }
                else if (sum1 == 106)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 101)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 106)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 108)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 109)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 111)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 112)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 113)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 114)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 115)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 116)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 121)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 122)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 123)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 124)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 125)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (sum1 == 126)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightSalmon;
                }
            }
        }
    }
}
