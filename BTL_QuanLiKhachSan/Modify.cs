using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BTL_QuanLiKhachSan
{
    internal class Modify
    {
        SqlDataAdapter dataAdapter;
        public Modify()
        {
        }
        public DataTable getAllDichVu()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM tblDichVu";
            using (SqlConnection sqlConnection = new Connection().getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool AddDichVu(string tenDichVu, decimal giaDichVu)
        {
            string query = "INSERT INTO tblDichVu (TenDichVu, GiaDichVu) VALUES (@TenDichVu, @GiaDichVu)";
            using (SqlConnection sqlConnection = new Connection().getConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@TenDichVu", tenDichVu);
                    sqlCommand.Parameters.AddWithValue("@GiaDichVu", giaDichVu);
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateDichVu(int id, string tenDichVu, decimal giaDichVu)
        {
            string query = "UPDATE tblDichVu SET TenDichVu = @TenDichVu, GiaDichVu = @GiaDichVu WHERE Id = @Id";
            using (SqlConnection sqlConnection = new Connection().getConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlCommand.Parameters.AddWithValue("@TenDichVu", tenDichVu);
                    sqlCommand.Parameters.AddWithValue("@GiaDichVu", giaDichVu);
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteDichVu(int id)
        {
            string query = "DELETE FROM tblDichVu WHERE Id = @Id";
            using (SqlConnection sqlConnection = new Connection().getConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
