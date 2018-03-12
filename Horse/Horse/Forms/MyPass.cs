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
    public partial class MyPass : Form
    {
        public MyPass()
        {
            InitializeComponent();
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            lblErrorPass.Visible = false;
            if (txtNewPass.Text == txtNewPassRepeat.Text)
            {
                Class.MenuController myPass = new Class.MenuController();
                if (myPass.resetPass(txtNewPass.Text) == true)
                {
                    Forms.DialogOk dialogOk = new Forms.DialogOk();
                    this.Hide();
                    dialogOk.Show();
                }
            }
            else
            {
                lblErrorPass.Visible = true;
            }
        }
    }
}