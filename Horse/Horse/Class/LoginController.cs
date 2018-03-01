using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Horse.Class
{
    class LoginController : Connection
    {
        private bool estado = false;

        public bool Estado { get => estado; set => estado = value; }

        Connection myConnection = new Connection();

        public Boolean loginToTheSystem(string user, string pass)
        {
            SqlConnection connection=myConnection.getConnection();

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

            //bool estado = false;
            //try
            //{
            //    var connectionString = new Connection();
            //    using (var connection = new SqlConnection(connectionString.tryConnection()))
            //    {
            //        using (var command = new SqlCommand("LoginToHorse", connection))
            //        {
            //            command.CommandType = System.Data.CommandType.StoredProcedure;
            //            command.Connection.Open();
            //            command.Parameters.AddWithValue("@user", user);
            //            command.Parameters.AddWithValue("@pass", pass);
            //            var output = command.ExecuteScalar();
            //            if (output != null) estado= true;                      
            //        }
            //    }
            //}
            //catch
            //{
            //    estado= false;
            //}

        }
        
    }
}
