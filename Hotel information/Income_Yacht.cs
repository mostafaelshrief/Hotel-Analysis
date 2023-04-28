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

namespace Hotel_information
{
    public partial class Income_Yacht : Form
    {
        public Income_Yacht()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Income_Yacht_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mostafa\source\repos\Hotel information\Hotel information\Database1.mdf;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            String query = "select * from Income_Yacht";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home_Yacht_Page icome = new Home_Yacht_Page();
            icome.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IncomeCB.SelectedItem.ToString() == "" || PriceTB.Text == "" || TypeCB.SelectedItem.ToString() == "" || NumberTB.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {


                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Income_Yacht (Income,Type,Numbers,price) VALUES " +
                    "(@Income,@Type,@Numbers,@price)", Con);
                cmd.Parameters.AddWithValue("@Income", IncomeCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Type", TypeCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Numbers", NumberTB.Text);
                cmd.Parameters.AddWithValue("@price", PriceTB.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item successfully Added");

                Con.Close();

                populate();


            }
        }
        string updatePrice, updateNumbers;
        int STRUpdateprice, STRUPdateNumbers;

        private void button3_Click(object sender, EventArgs e)
        {
            double totin = 0.0;
            if (dataGridView1.Rows[0].Cells[3].Value == "Null")
            {
                label7.Text = totin.ToString();

            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totin += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
                label7.Text = totin.ToString();
            }
            Con.Open();
            string query = "update Total_YachtTbl set Total='" + label7.Text + "' where  Name='" + label1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query1 = "select * from Income_Yacht where (Income=N'" + IncomeCB.SelectedItem.ToString() + "' AND Type='" + TypeCB.SelectedItem.ToString() + "')";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                updatePrice = dr["price"].ToString();
                updateNumbers = dr["Numbers"].ToString();
            }
            STRUpdateprice = Convert.ToInt32(updatePrice) + Convert.ToInt32(PriceTB.Text);
            STRUPdateNumbers = Convert.ToInt32(updateNumbers) + Convert.ToInt32(NumberTB.Text);

            string query = "update Income_Yacht set Numbers='" + STRUPdateNumbers + "',price='" + STRUpdateprice + "' where (Income=N'" + IncomeCB.SelectedItem.ToString() + "' AND Type='" + TypeCB.SelectedItem.ToString() + "');";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data updateed successfully");

            Con.Close();
            populate();
        }
    }
}
