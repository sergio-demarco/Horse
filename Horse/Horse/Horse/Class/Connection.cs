using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Horse.Class
{
    class Connection
    {
        public string tryConnection(){
            {
                string connectionString;
                try
                {
                    connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                return connectionString;
            }
        }
}
}
