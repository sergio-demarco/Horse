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
    public partial class AddDebts : Form
    {
        private string idClient = "";
        public AddDebts()
        {
            InitializeComponent();
        }
        public AddDebts(string name, string lastname)
        {
            this.BringToFront();
            InitializeComponent();
            var client = getClient(name, lastname);
            txtClient.Text = "[" + client.Id.ToString() + "] " + client.Name.ToString() + " " + client.Lastname.ToString();
            this.idClient = client.Id.ToString();
        }

        private void AddDebts_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            txtClient.Enabled = false;
            txtDebt.Text = "0";
            txtInfavor.Text = "0";

        }
        private Class.Clients getClient(string name, string lastname)
        {
            Class.LoginController MyConnection = new Class.LoginController();
            SqlConnection connection = MyConnection.getConnection();
            Class.Clients myClient = new Class.Clients();
            string query = "select id, name, lastname, email, cuit, dni, adress, location, petname, razonsoc, phone, phone2 from clients where name='" + name + "' and lastname='" + lastname + "'";
            try
            {

                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection.Open();
                    //command.Parameters.AddWithValue("@username", user);
                    //command.Parameters.AddWithValue("@pass", pass);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            myClient.Id = reader[0].ToString();
                            myClient.Name = reader[1].ToString();
                            myClient.Lastname = reader[2].ToString();
                            myClient.Email = reader[3].ToString();
                            myClient.Cuit = reader[4].ToString();
                            myClient.Dni = reader[5].ToString();
                            myClient.Adress = reader[6].ToString();
                            myClient.Location = reader[7].ToString();
                            myClient.Petname = reader[8].ToString();
                            myClient.Razonsoc = reader[9].ToString();
                            myClient.Phone = reader[10].ToString();
                            myClient.Phone2 = reader[11].ToString();
                        }
                    }
                }

            }
            catch
            {
            }
            return myClient;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.LoginController MyConnection = new Class.LoginController();
            SqlConnection connection = MyConnection.getConnection();

            int count = 0;
            using (var command = new SqlCommand("INSERT INTO [dbo].[Debts] (idCliente,indebt,infavor) values ('" + this.idClient + "','" + txtDebt.Text + "','" + txtInfavor.Text + "')", connection))
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection.Open();
                count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    Color myColor = System.Drawing.Color.Black;
                    Forms.DialogOk insertOk = new Forms.DialogOk("Los datos fueron grabados con exito!", myColor);
                    insertOk.Show();
                    insertOk.BringToFront();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
