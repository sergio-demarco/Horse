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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login miLogin = new Login();
            this.Hide();  // oculta el form inicial 
            miLogin.ShowDialog(this);  // (muestra el form de tu app)
            this.Dispose();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Password pass = new Forms.Password();
            pass.Show();
        }

        private void miContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.MyPass pass = new Forms.MyPass();
            pass.Show();
        }

        private void gestionarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Permision myPermission  = new Forms.Permision();
            myPermission.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
