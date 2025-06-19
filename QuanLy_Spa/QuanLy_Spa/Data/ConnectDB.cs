using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Spa.Data
{
    public class ConnectDB
    {
        public static string chuoiketnoi = "Data Source=DESKTOP-Q6SSN2P;Initial Catalog=SP;User ID=sa; Password=123";
        public SqlConnection conn = new SqlConnection();
        public ConnectDB()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public int getNonQuery(string sqlquery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }
        public DataTable getDataTable(string sqlquery)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }
        public int getScalar(string sqlquery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            int kq = (int)cmd.ExecuteScalar();
            Close();
            return kq;
        }

    }
}
