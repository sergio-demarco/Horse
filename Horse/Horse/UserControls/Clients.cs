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
    public partial class Clients : UserControl
    {
        string query = "";
        private static Clients _instance;

        public static Clients Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Clients();
                return _instance;
            }
        }
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            query = "select id, name,lastname,email,cuit,dni,adress,location,petname,razonsoc,phone,phone2 from Clients ";
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
            this.query = "select id, name,lastname,email,cuit,dni,adress,location,petname,razonsoc,phone,phone2 from Clients where (id is null) ";
            string customQuery;
            string clientSearch = "";
            if (txtClients != null) { clientSearch = txtClients.Text; }
            if (checkAllChecks.Checked == true)
            {
                customQuery = "select id, name, lastname, email, cuit, dni, adress, location, petname, razonsoc, phone, phone2 from Clients where (name like'%" + clientSearch + "%' or name is null) or(lastname like'%" + clientSearch + "%' or lastname is null) or(email like'%" + clientSearch + "%' or email is null) or(cuit like'%" + clientSearch + "%' or cuit is null)or(dni like'%" + clientSearch + "%' or dni is null)or(adress like'%" + clientSearch + "%' or adress is null)or(location like'%" + clientSearch + "%' or location is null)or(petname like'%" + clientSearch + "%'  or petname is null)or(razonsoc like'%" + clientSearch + "%'  or razonsoc is null)or(phone like'%" + clientSearch + "%'  or phone is null)or(phone2 like'%" + clientSearch + "%'  or phone2 is null)";
                this.query = customQuery;
            }
            else
            {
                if (checkNombre.Checked == true)
                {
                    customQuery = " or (name like'%" + clientSearch + "%' or name is null)";
                    queryBuilder(customQuery);
                }
                if (checkApellido.Checked == true)
                {
                    customQuery = " or (lastname like'%" + clientSearch + "%' or lastname is null)";
                    queryBuilder(customQuery);
                }
                if (checkCorreo.Checked == true)
                {
                    customQuery = " or (email like'%" + clientSearch + "%' or email is null)";
                    queryBuilder(customQuery);
                }
                if (checkCuit.Checked == true)
                {
                    customQuery = " or (cuit like'%" + clientSearch + "%' or cuit is null)";
                    queryBuilder(customQuery);
                }
                if (checkDni.Checked == true)
                {
                    customQuery = "or (dni like'%" + clientSearch + "%' or dni is null)";
                    queryBuilder(customQuery);
                }
                if (checkDomicilio.Checked == true)
                {
                    customQuery = "or (adress like'%" + clientSearch + "%' or adress is null)";
                    queryBuilder(customQuery);
                }
                if (checkLocalidad.Checked == true)
                {
                    customQuery = "or (location like'%" + clientSearch + "%' or location is null)";
                    queryBuilder(customQuery);
                }
                if (checkNombreMascota.Checked == true)
                {
                    customQuery = "or (petname like'%" + clientSearch + "%' or petname is null)";
                    queryBuilder(customQuery);
                }
                if (checkRazSocial.Checked == true)
                {
                    customQuery = "or (razonsoc like'%" + clientSearch + "%' or razonsoc is null)";
                    queryBuilder(customQuery);
                }
                if (checkTelefono.Checked == true)
                {
                    customQuery = "or (phone like'%" + clientSearch + "%' or phone is null)";
                    queryBuilder(customQuery);
                }
                if (checkPhone2.Checked == true)
                {
                    customQuery = "or (phone2 like'%" + clientSearch + "%' or phone2 is null)";
                    queryBuilder(customQuery);
                }
            }


            try
            {
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
            catch
            {
            }
        }
        private void queryBuilder(string whereQuery)
        {
            this.query = this.query + whereQuery;
        }

        private void dataClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataClients.Columns[e.ColumnIndex].Name.Equals("Editar"))
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

                Forms.ModifyClient modifyClient = new Forms.ModifyClient(cliente);
                modifyClient.Show();
            }
        }

        private void checkAllChecks_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkAllChecks.Checked == true)
            {
                checkNombre.Checked = true;
                checkApellido.Checked = true;
                checkCorreo.Checked = true;
                checkCuit.Checked = true;
                checkDni.Checked = true;
                checkDomicilio.Checked = true;
                checkLocalidad.Checked = true;
                checkNombreMascota.Checked = true;
                checkRazSocial.Checked = true;
                checkTelefono.Checked = true;
                checkPhone2.Checked = true;
            }
            else
            {
                checkNombre.Checked = false;
                checkApellido.Checked = false;
                checkCorreo.Checked = false;
                checkCuit.Checked = false;
                checkDni.Checked = false;
                checkDomicilio.Checked = false;
                checkLocalidad.Checked = false;
                checkNombreMascota.Checked = false;
                checkRazSocial.Checked = false;
                checkTelefono.Checked = false;
                checkPhone2.Checked = false;
            }
        }
    }
}
