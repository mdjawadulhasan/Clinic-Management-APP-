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
    public partial class Presecription : Form
    {
        public Presecription()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();

        private void fillPatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Patient from AppointmentTbl", Con);
            SqlDataReader rdr; rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(rdr);
            PatId.ValueMember = "Patient";
            PatId.DataSource = dt;
            Con.Close();
        }

        private void fillTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TreatName from TreatmentTbl", Con);
            SqlDataReader rdr; rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(rdr);
            PatId.ValueMember = "Patient";
            PatId.DataSource = dt;
            Con.Close();
        }

        private void GetTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from AppointmentTbl where Patient='" + PatId.SelectedValue.ToString() + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreatTb.Text = dr["Treatment"].ToString();
            }

            Con.Close();
        }

        private void GetPrice()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from TreatmentTbl where TreatName='" + TreatTb.Text + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreatCostTb.Text = dr["TreatCost"].ToString();
            }

            Con.Close();
        }
        private void Presecription_Load(object sender, EventArgs e)
        {
            fillPatient();
            populate();
        }
        void populate()
        {
            MyPatient Pat = new MyPatient();
            string query = "select * from PrescriptionTbl";

            DataSet ds = Pat.ShowPatient(query);
            PrescriptionDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into Prescriptiontbl values('" + PatId.SelectedValue.ToString() + "','" + TreatTb.Text + "'," + TreatCostTb.Text + ",'" + Mdcntb.Text + "'," + QtyTb.Text + ")";
            MyPatient Pat = new MyPatient();
            try
            {
                Pat.AddPatient(query);
                MessageBox.Show("Treatment Successfully Added");
                populate();
                //clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void PatId_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTreatment();
        }

        private void TreatTb_TextChanged(object sender, EventArgs e)
        {
            GetPrice();
        }
        int key = 0;
        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.SelectedValue = PrescriptionDGV.SelectedRows[0].Cells[1].Value.ToString();
            TreatTb.Text = PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString();
            TreatCostTb.Text = PrescriptionDGV.SelectedRows[0].Cells[3].Value.ToString();
            Mdcntb.Text = PrescriptionDGV.SelectedRows[0].Cells[4].Value.ToString();
            QtyTb.Text = PrescriptionDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (TreatTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PrescriptionDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;

        private void button2_Click(object sender, EventArgs e)
        {
            int height = PrescriptionDGV.Height;
            PrescriptionDGV.Height = PrescriptionDGV.RowCount * PrescriptionDGV.RowTemplate.Height * 2;
            bitmap = new Bitmap(PrescriptionDGV.Width, PrescriptionDGV.Height);
            PrescriptionDGV.DrawToBitmap(bitmap, new Rectangle(0, 10, PrescriptionDGV.Width, PrescriptionDGV.Height));
            PrescriptionDGV.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        
    }
}
