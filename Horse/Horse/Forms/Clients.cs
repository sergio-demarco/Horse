using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse.Forms
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            string query = "select id, name,lastname,email,cuit,dni,adress,location,petname,razonsoc,phone,phone2 from Clients ";
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

        private void dataClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataClients.Columns[e.ColumnIndex].Name.Equals("Seleccionar"))
            {
                DataGridViewRow row = this.dataClients.Rows[e.RowIndex];

                string id = row.Cells[1].Value.ToString();
                string name = row.Cells[2].Value.ToString();
                string lastname = row.Cells[3].Value.ToString();
                string email = row.Cells[4].Value.ToString();
                string cuit = row.Cells[5].Value.ToString();
                string dni = row.Cells[6].Value.ToString();
                string adress = row.Cells[7].Value.ToString();
                string location = row.Cells[8].Value.ToString();
                string petname = row.Cells[9].Value.ToString();
                string razonsoc = row.Cells[10].Value.ToString();
                string phone = row.Cells[11].Value.ToString();
                string phone2 = row.Cells[12].Value.ToString();

                Class.Clients cliente = new Class.Clients(id, name, lastname, email, cuit, dni, adress, location, petname, razonsoc, phone, phone2);

                Forms.Calendar calendar = new Forms.Calendar(cliente);
                calendar.Show();
                calendar.BringToFront();
                    this.Hide();
                

            }
        }
    }
}
