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
    public partial class AddDebts : Form
    {
        public AddDebts()
        {
            InitializeComponent();
        }

        private void AddDebts_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            txtClient.Enabled = false;
            txtDebt.Text = "0";
            txtInfavor.Text = "0";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
