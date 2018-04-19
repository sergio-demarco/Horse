using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse.Forms
{
    public partial class ModifyClient : Form
    {
        public ModifyClient(Class.Clients client)
        {
            InitializeComponent();
            this.BringToFront();
            txtId.Text = client.Id;
            txtName.Text = client.Name;
            txtLastname.Text = client.Lastname;
            txtEmail.Text = client.Email;
            txtCuit.Text = client.Cuit;
            txtDni.Text = client.Dni;
            txtAdress.Text = client.Adress;
            txtLocation.Text = client.Location;
            txtPetname.Text = client.Petname;
            txtRazonsoc.Text = client.Razonsoc;
            txtPhone.Text = client.Phone;
            txtPhone2.Text = client.Phone2;
        }

        private void ModifyClient_Load(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
