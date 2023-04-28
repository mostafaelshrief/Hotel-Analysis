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

namespace Hotel_information.ExpensesFolder
{
    public partial class TheRopert : Form
    {
        public TheRopert()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Month_Report_Expenses month_Report_Expenses = new Month_Report_Expenses();
            month_Report_Expenses.Show();
            this.Hide();
        }

        private void TheRopert_Load(object sender, EventArgs e)
        {
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mostafa\Downloads\information_Hotel-master\Hotel information\Database1.mdf"";Integrated Security=True");





        string mon1, mon2, mon3, mon4, mon5, mon6, mon7, mon8, mon9, mon10, mon11, mon12;
        int total;
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (BillSelectedlist.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Missing information");
            }
            else { 
            Con.Open();
            string query = "select * from ExpensesTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string query1 = "select * from Expenses_FebTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            sda1.SelectCommand = cmd1;
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            string query2 = "select * from Expenses_MarTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd2 = new SqlCommand(query2, Con);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            sda2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            string query3 = "select * from Expenses_AprTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd3 = new SqlCommand(query3, Con);
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
            sda3.SelectCommand = cmd3;
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            string query4 = "select * from Expenses_MayTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd4 = new SqlCommand(query4, Con);
            SqlDataAdapter sda4 = new SqlDataAdapter(cmd4);
            sda4.SelectCommand = cmd4;
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            string query5 = "select * from Expenses_JunTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd5 = new SqlCommand(query5, Con);
            SqlDataAdapter sda5 = new SqlDataAdapter(cmd5);
            sda5.SelectCommand = cmd5;
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            string query6 = "select * from Expenses_JulTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd6 = new SqlCommand(query6, Con);
            SqlDataAdapter sda6 = new SqlDataAdapter(cmd6);
            sda6.SelectCommand = cmd6;
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            string query7 = "select * from Expenses_AugTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd7 = new SqlCommand(query7, Con);
            SqlDataAdapter sda7 = new SqlDataAdapter(cmd7);
            sda7.SelectCommand = cmd7;
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            string query8 = "select * from Expenses_SepTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd8 = new SqlCommand(query8, Con);
            SqlDataAdapter sda8 = new SqlDataAdapter(cmd8);
            sda8.SelectCommand = cmd8;
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
            string query9 = "select * from Expenses_OctTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd9 = new SqlCommand(query9, Con);
            SqlDataAdapter sda9 = new SqlDataAdapter(cmd9);
            sda9.SelectCommand = cmd9;
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            string query10 = "select * from Expenses_NovTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd10 = new SqlCommand(query10, Con);
            SqlDataAdapter sda10 = new SqlDataAdapter(cmd10);
            sda10.SelectCommand = cmd10;
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
            string query11 = "select * from Expenses_DecTbl where Type='" + BillSelectedlist.SelectedItem.ToString() + "'  ";
            SqlCommand cmd11 = new SqlCommand(query11, Con);
            SqlDataAdapter sda11 = new SqlDataAdapter(cmd11);
            sda11.SelectCommand = cmd11;
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            listBox1.DataSource = dt;
            listBox2.DataSource = dt1;
            listBox3.DataSource = dt2;
            listBox4.DataSource = dt3;
            listBox5.DataSource = dt4;
            listBox6.DataSource = dt5;
            listBox7.DataSource = dt6;
            listBox8.DataSource = dt7;
            listBox9.DataSource = dt8;
            listBox10.DataSource = dt9;
            listBox11.DataSource = dt10;
            listBox12.DataSource = dt11;
            listBox1.DisplayMember = "Price";
            listBox2.DisplayMember = "Price";
            listBox3.DisplayMember = "Price";
            listBox4.DisplayMember = "Price";
            listBox5.DisplayMember = "Price";
            listBox6.DisplayMember = "Price";
            listBox7.DisplayMember = "Price";
            listBox8.DisplayMember = "Price";
            listBox9.DisplayMember = "Price";
            listBox10.DisplayMember = "Price";
            listBox11.DisplayMember = "Price";
            listBox12.DisplayMember = "Price";
            listBox1.ValueMember = "Price";
            listBox2.ValueMember = "Price";
            listBox3.ValueMember = "Price";
            listBox4.ValueMember = "Price";
            listBox5.ValueMember = "Price";
            listBox6.ValueMember = "Price";
            listBox7.ValueMember = "Price";
            listBox8.ValueMember = "Price";
            listBox9.ValueMember = "Price";
            listBox10.ValueMember = "Price";
            listBox11.ValueMember = "Price";
            listBox11.ValueMember = "Price";
            Con.Close();
            mon1 = Convert.ToString(listBox1.Text);
            mon2 = Convert.ToString(listBox2.Text);
            mon3 = Convert.ToString(listBox3.Text);
            mon4 = Convert.ToString(listBox4.Text);
            mon5 = Convert.ToString(listBox5.Text);
            mon6 = Convert.ToString(listBox6.Text);
            mon7 = Convert.ToString(listBox7.Text);
            mon8 = Convert.ToString(listBox8.Text);
            mon9 = Convert.ToString(listBox9.Text);
            mon10 = Convert.ToString(listBox10.Text);
            mon11 = Convert.ToString(listBox11.Text);
            mon12 = Convert.ToString(listBox12.Text);
            total = Convert.ToInt32(mon1) + Convert.ToInt32(mon2) + Convert.ToInt32(mon3) + Convert.ToInt32(mon4) + Convert.ToInt32(mon5) + Convert.ToInt32(mon5) + Convert.ToInt32(mon6) + Convert.ToInt32(mon7) + Convert.ToInt32(mon8) + Convert.ToInt32(mon9) + Convert.ToInt32(mon10) + Convert.ToInt32(mon11) + Convert.ToInt32(mon12) ;
            label16.Text=Convert.ToString(total);
            }
        }
    }
}
