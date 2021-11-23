using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;

namespace TimKiemSach
{
    class provider
    {
        string cs = ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString;
        public provider() { }
        public  DataTable ExecuteQuery(string query, object[] parameter = null)
        {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
                return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Close();
            }
            return data;
        }
    }
}
