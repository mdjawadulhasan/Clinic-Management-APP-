using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        void populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select *from UserTbl";
            DataSet ds = Pat.ShowPatient(query);
            UserDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into UserTbl values('" + UsernameTb.Text + "','" + PasswordTb.Text + "','" + PhoneTb.Text + "')";
            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("User Succesfully Aded");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }
    }
}
