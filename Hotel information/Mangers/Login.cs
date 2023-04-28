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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Missing information");
            }
            else if (textBox1.Text=="MR.HANY")
            {
                Manger_Report manger_Report = new Manger_Report();
                manger_Report.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid password");
            }
        }
    }
}
