using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien_ThongTinUser.DAO
{
    class DataProvider
    {
        private string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=Library;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            connection.Close();
            return data;
        }


    }
}
