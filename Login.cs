using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }
        ConnectionString MyConnection = new ConnectionString();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = MyConnection.GetCon();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where uname='" + Uname.Text + "' and Upass='" + Upass.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Appoinment App = new Appoinment();
                App.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password");
                Uname.Text = "";
                Upass.Text = "";
            }
            Con.Close();
        }
    }
}
