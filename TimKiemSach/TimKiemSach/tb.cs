using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace TimKiemSach
{
    class tb
    {
        string cs = ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString;
        SqlDataAdapter DataAdapter;
        public tb() { }
        public DataTable getTable()
        {
            DataTable dataTable = new DataTable();
            string querry = "select * from Book";
            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();
                DataAdapter = new SqlDataAdapter(querry, cn);
                DataAdapter.Fill(dataTable);
                cn.Close();
            }
            return dataTable;
        }
    }
}
