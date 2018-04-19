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
    public partial class DialogOk : Form
    {
        public DialogOk(string message)
        {
            lblDialogOk.Text = message;
            InitializeComponent();
        }

        private void btnDialogOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DialogOk_Load(object sender, EventArgs e)
        {

        }
    }
}