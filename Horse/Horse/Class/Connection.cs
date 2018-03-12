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
        public SqlConnection getConnection()
        {
            try
            {
                SqlConnection Conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["HorseConnection"].ToString());
                Conectar.Open();
                Conectar.Close();

                return Conectar;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
