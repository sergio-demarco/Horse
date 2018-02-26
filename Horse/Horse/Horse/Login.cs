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
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            MainView miForm1 = new MainView();
            this.Hide();  // oculta el form inicial 
            miForm1.ShowDialog(this);  // (muestra el form de tu app)
            this.Dispose();




            //Class.LoginController systemLogin = new Class.LoginController();
            //if (systemLogin.loginToTheSystem(txtUsuario.ToString(), txtContrasena.ToString()))
            //{
            //    this.Hide();
            //    MainView frm = new MainView();
            //    frm.Show();
            //}
        }
    }
}
