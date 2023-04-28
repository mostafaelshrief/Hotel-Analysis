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

namespace Hotel_information.Resturant.IncomeRestutant
{
    public partial class Oct_income : Form
    {
        public Oct_income()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Report_Income report_Income = new Report_Income();
            report_Income.Show();
            this.Hide();
        }

        private void Apr_Income_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mostafa\Downloads\information_Hotel-master\Hotel information\Database1.mdf"";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "Select * from Resturant_OctTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "" || textBox1.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand sql = new SqlCommand("Insert Into Resturant_OctTbl (Income,Price,Comment) Values" + "(@Income,@Price,@Comment)", Con);
                sql.Parameters.AddWithValue("@Income", comboBox1.SelectedItem.ToString());
                sql.Parameters.AddWithValue("@Price", textBox1.Text);
                sql.Parameters.AddWithValue("@Comment", textBox2.Text);
                sql.ExecuteNonQuery();
                MessageBox.Show("Item saved successfully");
                Con.Close();
                populate();
            }
        }
        string updatePrice;
        int UPdatePriceINT;
        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from Resturant_OctTbl Where Income='" + comboBox1.SelectedItem.ToString() + "'";
            SqlCommand sqlCommand = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                updatePrice = dr["Price"].ToString();
            }
            UPdatePriceINT = Convert.ToInt32(updatePrice) + Convert.ToInt32(textBox1.Text);
            string query1 = "update Resturant_OctTbl set Price='" + UPdatePriceINT + "',Comment='" + textBox2.Text + "'";
            SqlCommand sql = new SqlCommand(query1, Con);
            sqlCommand.ExecuteNonQuery();
            sql.ExecuteNonQuery();
            MessageBox.Show("Data Update successfully");
            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "delete from Resturant_OctTbl where Income='" + comboBox1.SelectedItem.ToString() + "'";
                SqlCommand sql = new SqlCommand(query, Con);
                sql.ExecuteNonQuery();
                MessageBox.Show("Item deleted successfully");
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
            if (dataGridView1.Rows[0].Cells[1].Value == "Null")
            {
                label7.Text = totin.ToString();

            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totin += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                label7.Text = totin.ToString();
            }
            Con.Open();

            string query = "update Analysis_OctTblR set Total='" + label7.Text + "' where  Name='" + label1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        private void Oct_income_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query1 = "select * from Analysis_TotTblR where Name='" + label1.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                updatePrice = dr["Total"].ToString();
            }
            STRUpdateprice = Convert.ToInt32(updatePrice) + Convert.ToInt32(label7.Text);

            string query = "update Analysis_TotTblR set Total='" + STRUpdateprice + "' where  Name='" + label1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Data updateed successfully");

            Con.Close();
            populate();
        }
        int STRUpdateprice;
    }
}
