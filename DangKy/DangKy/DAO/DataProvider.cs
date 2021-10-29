using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKy.DAO
{
    class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = "Data Source=DESKTOP-0E1NOTR;Initial Catalog=Library;Integrated Security=True";

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
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                        data = command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e);
                        Console.WriteLine(e.StackTrace);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return data;
        }
    }
}
