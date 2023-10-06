using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBANHANG
{
    class MODIFY
    {
        public MODIFY()
        {

        }
        SqlCommand sqlCommand; // Truy vấn câu lệnh
        SqlDataReader dataReader; // Đọc dữ liệu trong bảng
        public List<TAIKHOAN> TAIKHOANs(string query)
        {
            List<TAIKHOAN> tAIKHOANs = new List<TAIKHOAN>();
            using (SqlConnection sqlConnection = CONNECTION.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tAIKHOANs.Add(new TAIKHOAN(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }    
            return tAIKHOANs;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = CONNECTION.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

    }
}
