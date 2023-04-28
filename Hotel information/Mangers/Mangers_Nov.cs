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

namespace Hotel_information.Mangers
{
    public partial class Mangers_Nov : Form
    {
        public Mangers_Nov()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mostafa\Downloads\information_Hotel-master\Hotel information\Database1.mdf"";Integrated Security=True");

        string updatePrice;
        int STRUpdateprice;
        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query1 = "select * from Manger_Nov where Name=N'" + textBox1.Text + "'";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                updatePrice = dr["commission"].ToString();
            }
            STRUpdateprice = Convert.ToInt32(updatePrice) + Convert.ToInt32(textBox2.Text);
            string query = "update Manger_Nov set commission='" + STRUpdateprice + "' where Name=N'" + textBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updateed successfully");
            Con.Close();
            populate();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from Manger_Nov";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Mangers_Dec_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                Con.Open();
                String query = "insert into Manger_Nov values(N'" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item added successfully");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double totin = 0.0;
            if (dataGridView1.Rows[0].Cells[1].Value == "Null")
            {
                label5.Text = totin.ToString();

            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totin += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                label5.Text = totin.ToString();
            }
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Manger_Report manger_Report = new Manger_Report();
            manger_Report.Show();
            this.Hide();
        }

        private void Mangers_Nov_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
