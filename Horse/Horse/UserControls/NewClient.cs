using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtApellido.Text ="";
            txtCorreo.Text = "";
            txtCuit.Text = "";
            txtDni.Text = "";
            txtDomicilio.Text = "";
            txtLocalidad.Text = "";
            txtNombre.Text = "";
            txtNombreMascota.Text = "";
            txtRazonSoc.Text = "";
            txtTelefono.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
