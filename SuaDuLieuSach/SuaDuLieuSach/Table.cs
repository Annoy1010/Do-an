using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace SuaDuLieuSach
{
    class Table
    {
        string cs = ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString;
        SqlDataAdapter DataAdapter;
        public Table() { }
        public DataTable getTable()
        {
            DataTable dataTable = new DataTable();
            string querry = "select * from Book";
            using(SqlConnection connection =new SqlConnection(cs))
            {
                connection.Open();
                DataAdapter = new SqlDataAdapter(querry,connection);
                DataAdapter.Fill(dataTable);
                connection.Close();
            }
                return dataTable;
        }
        public bool Update(Sach sach)
        {
            SqlConnection connection =new SqlConnection(cs);
            string querry = "update Book set TENSA=@TENSA,LOAISA=@LOAISA,NXB= @NXB,TACGIA=@TACGIA,TAIBAN=@TAIBAN,SOLUONG=@SOLUONG where MASA=@MASA";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querry, connection);
                command.Parameters.Add("@MASA", SqlDbType.NVarChar).Value = sach.maSach;
                command.Parameters.Add("@TENSA", SqlDbType.NVarChar).Value = sach.tenSach;
                command.Parameters.Add("@LOAISA", SqlDbType.NVarChar).Value = sach.loaiSach;
                command.Parameters.Add("@NXB", SqlDbType.NVarChar).Value = sach.nhaXuatBan;
                command.Parameters.Add("@TACGIA", SqlDbType.NVarChar).Value = sach.tagGia;
                command.Parameters.Add("@TAIBAN", SqlDbType.Int).Value = sach.taiBan;
                command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = sach.soLuong;
                command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        
    }
}
