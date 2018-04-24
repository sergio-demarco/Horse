using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Horse.UserControls
{
    public partial class Debts : UserControl
    {
        private static Debts _instance;
        public static Debts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Debts();
                return _instance;
            }
        }
        public Debts()
        {
            InitializeComponent();
        }

        private void Debts_Load(object sender, EventArgs e)
        {
            //select d.indebt,d.infavor,c.name,c.lastname,c.phone,c.phone2 from clients c inner  join debts d on c.id=d.idCliente 
            //            string query = "select d.indebt,d.infavor,c.name,c.lastname,c.phone,c.phone2 from clients c inner  join debts d on c.id=d.idCliente  ";
            string query = "select sum(d.indebt) as debe,sum(d.infavor) as afavor,c.name,c.lastname from clients c inner  join debts d on c.id=d.idCliente group by c.name,c.lastname order by debe desc";
            txtClients.Focus();
            Class.LoginController MyConnection = new Class.LoginController();
            SqlConnection connection = MyConnection.getConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = query;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataClients.AutoGenerateColumns = false;
            dataClients.DataSource = dtRecord;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
