using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Horse.Class
{
    class LoginController
    {
        private bool estado = true;

        public bool Estado { get => estado; set => estado = value; }

        public Boolean loginToTheSystem(string user, string pass)
        {
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
            return estado;
        }
        
    }
}
