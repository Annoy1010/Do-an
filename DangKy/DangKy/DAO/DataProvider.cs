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
        private string connectionStr = "Data Source=DESKTOP-0E1NOTR;Initial Catalog=SignUp;Integrated Security=True";

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

        public int ExecuteInsertUserQuery(object[] parameter = null)
        {
            int rowCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO UserAccount VALUES (@userDB,@passDB,@nameDB,@ageDB,@passportDB,@phoneDB,@borrowDB,@adminDB)";
                    SqlCommand command = new SqlCommand(query, connection);

                    for (int i = 0; i < 8; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                command.Parameters.AddWithValue("@userDB", parameter[i]);
                                break;
                            case 1:
                                command.Parameters.AddWithValue("@passDB", parameter[i]);
                                break;
                            case 2:
                                command.Parameters.AddWithValue("@nameDB", parameter[i]);
                                break;
                            case 3:
                                command.Parameters.AddWithValue("@ageDB", parameter[i]);
                                break;
                            case 4:
                                command.Parameters.AddWithValue("@passportDB", parameter[i]);
                                break;
                            case 5:
                                command.Parameters.AddWithValue("@phoneDB", parameter[i]);
                                break;
                            case 6:
                                command.Parameters.AddWithValue("@borrowDB", parameter[i]);
                                break;
                            case 7:
                                command.Parameters.AddWithValue("@adminDB", parameter[i]);
                                break;
                            default:
                                break;
                        }
                    }
                    rowCount = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
                Console.Read();
            }
            return rowCount;
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
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

    }
}
