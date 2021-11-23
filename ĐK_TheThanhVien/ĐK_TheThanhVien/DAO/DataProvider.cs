using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ĐK_TheThanhVien.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = @"Data Source=LAPTOP-317MM1BK\SQLEXPRESS;Initial Catalog=Library;Persist Security Info=True;User ID=panda;Password=17032003";
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
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
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    try
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (var item in listPara)
                        {
                            if (item.Contains('@'))
                            {

                                command.Parameters.AddWithValue(item, parameter[i].ToString());
                                i++;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e);
                        Console.WriteLine(e.StackTrace);
                    }
                }
                data = command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Close();
            }
            return data;
        }
    }
}
