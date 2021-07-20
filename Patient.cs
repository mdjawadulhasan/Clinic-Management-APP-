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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select *from PatientTbl";
            DataSet ds = Pat.ShowPatient(query);
            PatientDGV.DataSource = ds.Tables[0];
        }
        private void Patient_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void save_Click(object sender, EventArgs e)
        {
            string query = "insert into PatientTbl values('" + PatNameTb.Text + "','" + PatPhooneTb.Text + "','" + AdressTb.Text + "','" + DOBDate.Value.Date + "','" + GenderTb.SelectedItem.ToString() + "','" + AllergyTb.Text + "')";
            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Patient Succesfully Aded");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


            
        }
        int key = 0;
       
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
            
            PatNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatPhooneTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            AdressTb.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            GenderTb.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            AllergyTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();

            if(PatNameTb.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }




        private void btndlt_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("select the patient");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTbl where Patid=" + key + "";
                    Pat.DeletePatietnt(query);
                    MessageBox.Show("Patient Succesfully Deleted");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("select the patient");
            }
            else
            {
                try
                {
                    string query = "Update PatientTbl set PatName='" + PatNameTb.Text + "',PatPhone='" + PatPhooneTb.Text + "',PatAdress='" + AdressTb.Text + "',PatDOB='" + DOBDate.Value.Date + "',PatGender='" + GenderTb.SelectedItem.ToString() + "',PatAllergies='" + AllergyTb.Text + "' where Patid=" + key + ";";
                    Pat.UpdatePatietnt(query);
                    MessageBox.Show("Patient Succesfully Updated");
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
