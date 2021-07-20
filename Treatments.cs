using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class Treatments
    {
        public void AddPatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public void DeletePatietnt(String query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public void UpdatePatietnt(String query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public DataSet ShowPatient(String query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
