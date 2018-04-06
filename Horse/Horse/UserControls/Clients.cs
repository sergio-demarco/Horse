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
            txtClients.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "select id ";
            string where1="";
            string where2="";
            string where3="";
            string where4="";
            string where5="";
            string where6="";
            string where7="";
            string where8="";
            string where9="";
            string where10="";
            string clientSearch = "";
            int flag = 0;
            if (txtClients == null) { clientSearch = ""; } else { clientSearch = txtClients.Text; }
            if (checkNombre.Checked == true)
            {
                flag = 1;
                query = query + ",name";
                where1 = where1 + " name like'%" + clientSearch+"%'";
            }
            if (checkApellido.Checked == true)
            {
                flag = 1;
                query = query + ",lastname";
                where2 = where2 + "lastname like'%" + clientSearch + "%'";
            }
            if (checkCorreo.Checked == true)
            {
                flag = 1;
                query = query + ",email";
                where3 = where3 + "email like'%" + clientSearch + "%'";
            }
            if (checkCuit.Checked == true)
            {
                flag = 1;
                query = query + ",cuit";
                where4 = where4 + "cuit like'%" + clientSearch + "%'";
            }
            if (checkDni.Checked == true)
            {
                flag = 1;
                query = query + ",dni";
                where5 = where5 + "dni like'%" + clientSearch + "%'";
            }
            if (checkDomicilio.Checked == true)
            {
                flag = 1;
                query = query + ",adress";
                where6 = where6 + "adress like'%" + clientSearch + "%'";
            }
            if (checkLocalidad.Checked == true)
            {
                flag = 1;
                query = query + ",location";
                where7 = where7 + "location like'%" + clientSearch + "%'";
            }
            
            if (checkNombreMascota.Checked == true)
            {
                flag = 1;
                query = query + ",petname";
                where8 = where8 + "petname like'%" + clientSearch + "%'";
            }
            if (checkRazSocial.Checked == true)
            {
                flag = 1;
                query = query + ",razonsoc";
                where9 = where9 + "razonsoc like'%" + clientSearch + "%'";
            }
            if (checkTelefono.Checked == true)
            {
                flag = 1;
                query = query + ",phone";
                where10 = where10 + "phone like'%" + clientSearch + "%'";
            }
            if (flag == 0)
            {
                query = "Select id, name,lastname,email,cuit,dni,adress,location,petname,razonsoc,phone from Clients";
            }
            else
            {
                query = query + " from Clients where " + where1 +" and "+ where2 + " and " + where3 + " and " + where4 + " and " + where5 + " and " + where6 + " and " + where7 + " and " + where8 + " and " + where9 + " and " + where10;
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

                //DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
                //{
                //    buttons.HeaderText = "";
                //    buttons.Text = "Editar";
                //    buttons.UseColumnTextForButtonValue = true;
                //    buttons.AutoSizeMode =
                //        DataGridViewAutoSizeColumnMode.AllCells;
                //    buttons.FlatStyle = FlatStyle.Standard;
                //    buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                //    buttons.DisplayIndex = 0;
                //}

                //dataClients.Columns.Add(buttons);



            }
            catch
            {


            }

           

        }

        private void dataClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataClients.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                string name = this.dataClients.Columns[1].ToString();
                string lastname = this.dataClients.Columns[2].ToString();
                string email = this.dataClients.Columns[3].ToString();
                string cuit = this.dataClients.Columns[4].ToString();
                string dni = this.dataClients.Columns[5].ToString();
                string adress = this.dataClients.Columns[6].ToString();
                string location = this.dataClients.Columns[7].ToString();
                string petname = this.dataClients.Columns[8].ToString();
                string razonsoc = this.dataClients.Columns[9].ToString();
                string phone = this.dataClients.Columns[10].ToString();

                MainView mainView = new MainView();
                mainView.OpenModifyCliente(name, lastname, email, cuit, dni, adress, location, petname, razonsoc, phone);
            }
        }
    }
}
