using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Clinic
{
    public partial class Appoinment : Form
    {
        public Appoinment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        ConnectionString MyCon = new ConnectionString();

        private void fillPatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PatName from PatientTbl", Con);
            SqlDataReader rdr; rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatName", typeof(string));
            dt.Load(rdr);
            PatientCb.ValueMember = "PatName";
            PatientCb.DataSource = dt;
            Con.Close();
        }

        private void fillTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TreatName from TreatmentTbl", Con);
            SqlDataReader rdr; rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TreatName", typeof(string));
            dt.Load(rdr);
            TreatmentCb.ValueMember = "TreatName";
            TreatmentCb.DataSource = dt;
            Con.Close();

        }

        private void Appoinment_Load(object sender, EventArgs e)
        {
            fillPatient();
            fillTreatment();
            populate();
        }
        void populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select *from AppointmentTbl ";
            DataSet ds = Pat.ShowPatient(query);
            Appointmentdgv.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into AppointmentTbl values('" + PatientCb.SelectedValue.ToString() + "','" + TreatmentCb.SelectedValue.ToString() + "','" + Date.Value.Date + "','" + Time.Value.TimeOfDay + "')";
            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Appointment  Succesfully Recorded");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void Appointmentdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientCb.SelectedValue = Appointmentdgv.SelectedRows[0].Cells[1].Value.ToString();
            TreatmentCb.SelectedValue = Appointmentdgv.SelectedRows[0].Cells[2].Value.ToString();
            string pat = Appointmentdgv.SelectedRows[0].Cells[2].Value.ToString();



            if (pat=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Appointmentdgv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("select the Appointment to Cancel");
            }
            else
            {
                try
                {
                    string query = "Delete from AppointmentTbl where Apid=" + key + "";
                    Pat.DeletePatietnt(query);
                    MessageBox.Show("Appointment  Succesfully Deleted");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("select the Appointment");
            }
            else
            {
                try
                {
                    string query = "Update AppointmentTbl set Patient='" + TreatmentCb.SelectedValue.ToString() + "',Treatment='" + TreatmentCb.SelectedValue.ToString() + "',ApDate='" + Date.Value.Date + "',ApTime='" + Time.Value.TimeOfDay + "' where Apid=" + key + ";";
                    Pat.UpdatePatietnt(query);
                    MessageBox.Show("Appointment Succesfully Updated");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
