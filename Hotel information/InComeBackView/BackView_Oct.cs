using Microsoft.Data.SqlClient;
using System.Data;

namespace Hotel_information.InComeBackView
{
    public partial class BackView_Oct : Form
    {
        public BackView_Oct()
        {
            InitializeComponent();
        }

        private void BackView_Oct_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mostafa\Downloads\information_Hotel-master\Hotel information\Database1.mdf"";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            String query = "select * from BackView_OctTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Month_Report_BackView icome = new Month_Report_BackView();
            icome.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RoomTb.Text == "" || PriceTb.Text == "" || DayTb.Text == "")
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
                double totin = 0.0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totin += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }
                label12.Text = totin.ToString();

                Con.Open();
                String query = "insert into BackView_OctTbl values(N'" + RoomTb.Text + "','" + PriceTb.Text + "','" + DayTb.Text + "','" + PriceTotalLbl.Text + "','" + label12.Text + "')";
                SqlCommand cmd = new SqlCommand("INSERT INTO BackView_OctTbl (Room,Price,Type,Days,TotalPrice) VALUES " +
                    "(@Room,@Price,@Type,@Days,@TotalPrice)", Con);
                cmd.Parameters.AddWithValue("@Room", RoomTb.Text);
                cmd.Parameters.AddWithValue("@Price", PriceTb.Text);
                cmd.Parameters.AddWithValue("@Type", TypeCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Days", DayTb.Text);
                cmd.Parameters.AddWithValue("@TotalPrice", PriceTotalLbl.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item successfully Added");

                Con.Close();

                populate();


            }

        }
        string updatePrice, updateDays, updateTotalPtice;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "delete from BackView_OctTbl where Room=N'" + RoomTb.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Deleted successfully");
                Con.Close();
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double totin = 0.0;
            if (dataGridView1.Rows[0].Cells[4].Value == "Null")
            {
                label12.Text = totin.ToString();

            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totin += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }
                label12.Text = totin.ToString();
            }
            Con.Open();
            string query = "update Total_OctTbl set Total='" + label12.Text + "' where  Name='" + label1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Con.Open();
            string query1 = "select * from TotalTbl where Name='" + label1.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                updatePrice = dr["Total"].ToString();

            }
            STRUpdateprice = Convert.ToInt32(updatePrice) + Convert.ToInt32(label12.Text);

            string query = "update TotalTbl set Total='" + STRUpdateprice + "' where  Name='" + label1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Data updateed successfully");

            Con.Close();
            populate();
        }

        int STRUpdateprice, STRUPdatedays, STRUpdatetotalprice;
        private void button2_Click(object sender, EventArgs e)
        {
            int totalprice;
            string strTotal;
            totalprice = Convert.ToInt32(PriceTb.Text) * Convert.ToInt32(DayTb.Text);
            strTotal = totalprice.ToString();
            PriceTotalLbl.Text = strTotal;

            Con.Open();
            string query1 = "select * from BackView_OctTbl where (Room=N'" + RoomTb.Text + "' AND Type='" + TypeCB.SelectedItem.ToString() + "')";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                updatePrice = dr["Price"].ToString();
                updateDays = dr["Days"].ToString();
                updateTotalPtice = dr["TotalPrice"].ToString();
            }

            STRUpdateprice = Convert.ToInt32(updatePrice) + Convert.ToInt32(PriceTb.Text);
            STRUPdatedays = Convert.ToInt32(updateDays) + Convert.ToInt32(DayTb.Text);
            STRUpdatetotalprice = Convert.ToInt32(updateTotalPtice) + Convert.ToInt32(PriceTotalLbl.Text);

            string query = "update BackView_OctTbl set Days='" + STRUPdatedays + "',TotalPrice='" + STRUpdatetotalprice + "' where (Room=N'" + RoomTb.Text + "' AND Type='" + TypeCB.SelectedItem.ToString() + "');";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updateed successfully");
            Con.Close();
            populate();
        }
    }
}
