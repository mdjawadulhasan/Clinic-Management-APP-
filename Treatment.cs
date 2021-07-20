﻿using System;
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
    public partial class Treatment : Form
    {
        public Treatment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into TreatmentTbl values('" + TretNameTb.Text + "','" + TreatCost.Text + "','" + TreatDesc.Text + "')";
            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Treatment Succesfully Aded");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }
        void populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select *from TreatmentTbl";
            DataSet ds = Pat.ShowPatient(query);
            TreatmentDGV.DataSource = ds.Tables[0];
        }
        private void Treatment_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("select the Treatment");
            }
            else
            {
                try
                {
                    string query = "Update TreatmentTbl set TreatName='" + TretNameTb.Text + "',TreatCost='" + TreatCost.Text + "',TreatDesc='" + TreatDesc.Text + "' where TreatID=" + key + ";";
                    Pat.UpdatePatietnt(query);
                    MessageBox.Show("Treatment Succesfully Updated");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TreatmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TretNameTb.Text = TreatmentDGV.SelectedRows[0].Cells[1].Value.ToString();
            TreatCost.Text = TreatmentDGV.SelectedRows[0].Cells[2].Value.ToString();
            TreatDesc.Text = TreatmentDGV.SelectedRows[0].Cells[3].Value.ToString();


            if (TretNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TreatmentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyPatient Pat = new MyPatient();
            if (key == 0)
            {
                MessageBox.Show("select the Treatment");
            }
            else
            {
                try
                {
                    string query = "Delete from TreatmentTbl where TreatID=" + key + "";
                    Pat.DeletePatietnt(query);
                    MessageBox.Show("Treatment Succesfully Deleted");
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
