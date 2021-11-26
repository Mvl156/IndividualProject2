using System;
using System.Data.SqlClient;
using System.Data;

namespace IndividueelProject2Library
{
    public class Customer
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        string Username { get; set; }
        string Password { get; set; }

        void connectionString()
        {
            con.ConnectionString = "Server=mssql.fhict.local;Database=dbi412106;User Id = dbi412106; Password=Martijn2001";
        }

        public bool Login(string Username, string Password)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM tbl_Customer WHERE Username='"+Username+"' AND Password='"+Password+"'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
