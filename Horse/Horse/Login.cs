using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            lblErrorLogin.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;
            Class.LoginController myLogin = new Class.LoginController();
            myLogin.loginToTheSystem(txtUsuario.Text, txtContrasena.Text);
            if (myLogin.Estado == true)
            {
                myLogin.checkIfIsAdmin(txtUsuario.Text, txtContrasena.Text);

                MainView miForm1 = new MainView();
                this.Hide();  // oculta el form inicial 
                miForm1.ShowDialog(this);  // (muestra el form de tu app)
                this.Dispose();
            }
            else
            {
                lblErrorLogin.Visible = true;
            }
        }
    }
}
