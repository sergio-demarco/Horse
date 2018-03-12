using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse.Class
{
    class MenuController
    {
        private Connection myConnection = new Connection();
        public bool resetPass(string pass)
        {
            SqlConnection connection = myConnection.getConnection();
            LoginController myLogin = new LoginController();
            string username = myLogin.getUser();
            bool success = false;
            try
            {

                using (var command = new SqlCommand("ResetPassword", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Connection.Open();
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", pass);

                    int rowsUpdated = command.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                    {
                        success = true;
                    }

                }

            }
            catch
            {

            }
            return success;
        }
    }
}