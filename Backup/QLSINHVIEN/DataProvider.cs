using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLSINHVIEN
{
    class DataProvider
    {
        private string connectionSTR = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Administrator\Documents\Visual Studio 2008\Projects\QLSINHVIEN\QLSINHVIEN\NhanVien .mdf;Integrated Security=True;User Instance=True";
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        public DataTable ExcuteQuery(string cmd)
        {
            DataTable dtb = new DataTable();
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dtb);
            connection.Close();
            return dtb;
        }
        public int ExcuteNonQuery(string cmd)
        {
            int data = 0;
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            try
            {
                data = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
                connection.Close();
            return data;
        }
        public int ExcuteScalar(string cmd)
        {
            int data;
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            data = (int)command.ExecuteScalar();
            connection.Close();
            return data;
        }

    }
}
