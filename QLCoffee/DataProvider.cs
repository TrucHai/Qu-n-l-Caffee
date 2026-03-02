using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCoffee   // ⚠ nhớ đúng tên project của bạn
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }
        }

        private string connectionSTR =
            @"Data Source=.;Initial Catalog=QLCoffee;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable data = new DataTable();
                adapter.Fill(data);

                return data;
            }
        }
    }
}