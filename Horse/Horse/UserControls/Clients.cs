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
    public partial class Clients : UserControl
    {
        private static Clients _instance;

        public static Clients Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Clients();
                return _instance;
            }
        }
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            txtClients.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }


    }
}
