using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ServiceProcess;

namespace Horse.Class
{
    class LoginController : Connection
    {

        private bool estado = false;
        public bool Estado { get => estado; set => estado = value; }
        static internal string userActive;
        public static string User { get; set; }
        internal Connection MyConnection { get => myConnection; set => myConnection = value; }
        private Connection myConnection = new Connection();

        public LoginController()
        {
        }

        public string getUserActive()
        {
            return userActive;
        }

        public void setUserActive(string user)
        {
            userActive = user;
        }
        public Boolean loginToTheSystem(string user, string pass)
        {
            SqlConnection connection = MyConnection.getConnection();

            int count = 0;
            try
            {

                using (var command = new SqlCommand("LoginToHorse", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Connection.Open();
                    command.Parameters.AddWithValue("@username", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count++;
                        }
                        if (count > 0) estado = true;
                    }
                }

            }
            catch
            {
                estado = false;

            }
            return estado;
        }

        public Boolean checkIfIsAdmin(string user, string pass)
        {
            SqlConnection connection = MyConnection.getConnection();

            string isAdmin = string.Empty;
            try
            {

                using (var command = new SqlCommand("IsAdmin", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Connection.Open();
                    command.Parameters.AddWithValue("@username", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            isAdmin = reader[0].ToString();
                        }
                    }
                }

            }
            catch
            {
                estado = false;

            }
            return estado;
        }
    }
}
