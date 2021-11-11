using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TimKiemSach
{
    class Tabl
    {
        SqlDataAdapter DataAdapter;
        public Table() { }
        public DataTable getTable()
        {
            DataTable dataTable = new DataTable();
            string querry = "select * from Book";
            using (SqlConnection connection = Connection.getConnection())
            {
                connection.Open();
                DataAdapter = new SqlDataAdapter(querry, connection);
                DataAdapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
    }
}
