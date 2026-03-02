using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLCoffee.DTO;

namespace QLCoffee.DAL
{
    public class AccountDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=QLCoffee;Integrated Security=True";// thay 

        public string CheckLogin(AccountDTO account)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Role FROM Account WHERE Username=@user AND Password=@pass";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", account.Username);
                cmd.Parameters.AddWithValue("@pass", account.Password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }
            }

            return null;

        }

    }
}
