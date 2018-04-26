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
    public partial class NewClient : UserControl
    {
        private static NewClient _instance;

        public static NewClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewClient();
                return _instance;
            }
        }
        public NewClient()
        {
            InitializeComponent();
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtCuit.Text = "NO POSEE";
            txtDni.Text = "";
            txtDomicilio.Text = "";
            txtLocalidad.Text = "";
            txtNombre.Text = "";
            txtNombreMascota.Text = "";
            txtRazonSoc.Text = "NO POSEE";
            txtTelefono.Text = "";
            txtPhone2.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtCorreo.Text != "" && txtCuit.Text != "" && txtDni.Text != "" && txtDomicilio.Text != "" && txtLocalidad.Text != "" && txtNombre.Text != "" && txtNombreMascota.Text != "" && txtRazonSoc.Text != "" && txtTelefono.Text != "" && txtPhone2.Text != "")
            {
                bool userExist = checkIfUserExist(txtNombre.Text, txtApellido.Text);
                if (userExist)
                {
                    Color myColor = System.Drawing.Color.Red;
                    Forms.DialogOk insertOk = new Forms.DialogOk("El cliente ya existe!", myColor);
                    insertOk.Show();
                    insertOk.BringToFront();
                }
                else
                {
                    try
                    {
                        Class.LoginController MyConnection = new Class.LoginController();
                        SqlConnection connection = MyConnection.getConnection();

                        int count = 0;
                        using (var command = new SqlCommand("InsertClient", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Connection.Open();
                            command.Parameters.AddWithValue("@name", txtNombre.Text);
                            command.Parameters.AddWithValue("@lastname", txtApellido.Text);
                            command.Parameters.AddWithValue("@email", txtCorreo.Text);
                            command.Parameters.AddWithValue("@cuit", txtCuit.Text);
                            command.Parameters.AddWithValue("@dni", txtDni.Text);
                            command.Parameters.AddWithValue("@adress", txtDomicilio.Text);
                            command.Parameters.AddWithValue("@location", txtLocalidad.Text);
                            command.Parameters.AddWithValue("@petname", txtNombreMascota.Text);
                            command.Parameters.AddWithValue("@razonsoc", txtRazonSoc.Text);
                            command.Parameters.AddWithValue("@phone", txtTelefono.Text);
                            command.Parameters.AddWithValue("@phone2", txtPhone2.Text);

                            count = command.ExecuteNonQuery();
                            if (count > 0)
                            {
                                txtApellido.Text = "";
                                txtCorreo.Text = "";
                                txtCuit.Text = "NO POSEE";
                                txtDni.Text = "";
                                txtDomicilio.Text = "";
                                txtLocalidad.Text = "";
                                txtNombre.Text = "";
                                txtNombreMascota.Text = "";
                                txtRazonSoc.Text = "NO POSEE";
                                txtTelefono.Text = "";
                                txtPhone2.Text = "";

                                Color myColor = System.Drawing.Color.Black;
                                Forms.DialogOk insertOk = new Forms.DialogOk("Los datos fueron grabados con exito!", myColor);
                                insertOk.Show();
                                insertOk.BringToFront();
                            }
                        }

                    }
                    catch
                    {
                    }
                }

            }
            else
            {
                Color myColor = System.Drawing.Color.Red;
                Forms.DialogOk myDialog = new Forms.DialogOk("**Todos los campos deben ser completados**", myColor);
                myDialog.Show();
                myDialog.BringToFront();
            }
        }

        private bool checkIfUserExist(string name, string lastname)
        {
            Class.LoginController MyConnection = new Class.LoginController();
            SqlConnection connection = MyConnection.getConnection();

            int count = 0;
            using (var command = new SqlCommand("select id from clients where name='" + name + "' and lastname='" + lastname + "'", connection))
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection.Open();

                count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
