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

namespace Hotel_information.Resturant.ExpensesResturant
{
    public partial class Aug_Expenses : Form
    {
        public Aug_Expenses()
        {
            InitializeComponent();
        }

        private void Aug_Expenses_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mostafa\Downloads\information_Hotel-master\Hotel information\Database1.mdf"";Integrated Security=True");

        private void populate()
        {
            Con.Open();
            String query = "select * from Expenses_ResturantAugTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Restureanr_Report_Expenses _Report_Expenses = new Restureanr_Report_Expenses();
            _Report_Expenses.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "" || textBox1.Text == "")
            {
                MessageBox.Show("Missing information!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Expenses_ResturantAugTbl (Expenses,Price,Comment) VALUES " +
                    "(@Expenses,@Price,@Comment)", Con);
                cmd.Parameters.AddWithValue("@Expenses", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Price", textBox1.Text);
                cmd.Parameters.AddWithValue("@Comment", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item successfully Added");

                Con.Close();
                populate();
            }
        }
        string updatePrice;
        int STRUpdateprice;
        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query1 = "select * from Expenses_ResturantAugTbl where Expenses='" + comboBox1.SelectedItem.ToString() + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                updatePrice = dr["Price"].ToString();
            }
            STRUpdateprice = Convert.ToInt32(updatePrice) + Convert.ToInt32(textBox1.Text);

            string query = "update Expenses_ResturantAugTbl set Price='" + STRUpdateprice + "',Comment='" + textBox2.Text + "' where  Expenses='" + comboBox1.SelectedItem.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updateed successfully");
            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String query = "delete from Expenses_ResturantAugTbl where Expenses=N'" + comboBox1.SelectedItem.ToString() + "';";
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

            string query = "update Analysis_AugTblR set Total='" + label7.Text + "' where  Name='" + label1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
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
    }
}
