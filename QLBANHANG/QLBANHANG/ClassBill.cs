using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLBANHANG
{
    public class SqlConnectionData 
    { 
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=MSI;Initial Catalog=QLBanHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    class ClassBill
    {
        public static DataTable GetData(string proceduce)
        {
            DataTable tb = new DataTable();
            SqlConnection Conn = SqlConnectionData.Connect();
            Conn.Open();
            SqlCommand cmd = new SqlCommand(proceduce, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
    }
}
