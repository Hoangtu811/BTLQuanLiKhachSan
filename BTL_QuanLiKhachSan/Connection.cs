using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BTL_QuanLiKhachSan
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=ADMIN\SQLSERVER2022DEV;Initial Catalog=QLKS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
