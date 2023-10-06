using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBANHANG
{
    class CONNECTION
    {
        private static string stringConnection = @"Data Source=MSI;Initial Catalog=QLBanHang;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
